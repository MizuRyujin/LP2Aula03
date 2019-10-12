using System;
using System.Collections.Generic;

namespace PlayerManager4
{
    class Program
    {
        private static Random rnd;
        static void Main(string[] args)
        {
            // Block variables
            rnd = new Random();

            // Initialize the list
            List<Player> plrs = new List<Player>() {
                new Player(DefPlayerName(rnd.Next(3)), rnd.Next(101)),
                new Player(DefPlayerName(rnd.Next(3)), rnd.Next(101))
            };

            // Loop to fill list with random number of players
            for (int i = 0; i < rnd.Next(5, 11); i++)
            {
                plrs.Add(new Player(DefPlayerName(rnd.Next(3)), rnd.Next(101)));
            }

            // Loop to print said list
            Console.WriteLine("Unsorted list:");
            foreach (Player p in plrs)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            Console.WriteLine("Organized list:");
            Console.WriteLine(GetPlayersWithScoreGreaterThan(plrs, rnd.Next(25, 101)));

            
        }

        // Method to randomly select one of three names
        private static string DefPlayerName(int rnd)
        {
            switch (rnd)
            {
                case 0:
                    {
                        return "Marta";
                    }

                case 1:
                    {
                        return "Bruna";
                    }

                case 2:
                    {
                        return "Miguel";
                    }

                default:
                    return "OutOfNames_LoL";
            }
        }

        private static IEnumerable<Player> GetPlayersWithScoreGreaterThan
            (List<Player> plrs, int treshold)
        {
            foreach (Player p in plrs)
            {
                if (p.Score > treshold)
                {
                    yield return p;
                }
            }

            yield break;
        }
    }
}
