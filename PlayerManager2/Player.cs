using System;
using System.Diagnostics.CodeAnalysis;

namespace PlayerManager2
{
    class Player : IHasScore, IComparable<Player>
    {
        // Class properties
        public int Score { get; set; }
        public string Name { get; }

        public Player(string name, int score)
        {
            Name = name;

            if (score < 0)
            {
                Score = 0;
            }

            else
            {
                Score = score;
            }

        }

        public override string ToString()
        {
            return $"{Name} score is: {Score}";
        }

        public bool Equals([AllowNull] IHasScore other)
        {
            if (other == null || other.Score != Score)
            {
                return false;
            }

            return true;
        }

        public int CompareTo([AllowNull] Player other)
        {
            if (other == null || other.Score < Score)
            {
                return -1;
            }

            if (other.Score > Score)
            {
                return 1;
            }

            return 0;
        }
    }
}
