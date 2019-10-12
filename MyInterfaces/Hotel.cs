using System.Diagnostics.CodeAnalysis;

namespace MyInterfaces
{
    class Hotel : IHasScore
    {
        //Class properties
        public string Name { get; }
        public int Score { get; set; }
        public string Description { get; }
        public int NRooms { get; }
        public int NFloors { get; }

        // Constructor
        public Hotel(string name, string description, int nRooms, 
            int nFloors, int score)
        {
            Name = name;
            Description = description;
            NRooms = nRooms;
            NFloors = nFloors;

            if (score < 0)
            {
                Score = 0;
            }
            else if (score > 5)
            {
                Score = 5;
            }

            else
            {
                Score = score;
            }
        }

        public override string ToString()
        {
            return $"{Name} is a {Score} star hotel," +
                $" it is a {Description} with {NRooms} rooms";
        }

        public bool Equals([AllowNull] IHasScore other)
        {
            if (other == null || other.Score != Score)
            {
                return false;
            }

            return true;
        }
    }
}
