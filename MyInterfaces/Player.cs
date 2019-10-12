using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyInterfaces
{
    class Player : IHasScore
    {
        public int Score { get; set; }

        public string Name { get; }
        
        public Player(int score, string name)
        {
            if (score < 0)
            {
                Score = 0;
            }

            else
            {
                Score = score;
            }

            Name = name;
        }

        public override string ToString()
        {
            return $"Player score is: {Score}";
        }

        public bool Equals([AllowNull] IHasScore other)
        {
            if (other == null || other != this)
            {
                return false;
            }

            return true;
        }

        public int CompareTo([AllowNull] IHasScore other)
        {
            if (other == null || Score > other.Score)
            {
                return -1;
            }

            if (Score < other.Score)
            {
                return 1;
            }

            return 0;
        }
    }
}
