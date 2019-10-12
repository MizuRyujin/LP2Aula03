using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MyInterfaces
{
    class Hotel : IHasScore
    {
        //Class properties
        public string Name { get; }
        public int Score { get; set; }
        public string Description { get; }
        public int NRooms { get; }

        // Constructor
        public Hotel(string name, string description, int nRooms)
        {
            Name = name;
            Description = description;
            NRooms = nRooms;
        }

        public override string ToString()
        {
            return $"{Name} is a {Score} star hotel," +
                $" it is a {Description} with {NRooms} rooms";
        }

        public int CompareTo([AllowNull] IHasScore other)
        {
            throw new NotImplementedException();
        }

        public bool Equals([AllowNull] IHasScore other)
        {
            throw new NotImplementedException();
        }
    }
}
