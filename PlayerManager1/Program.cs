using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

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
            foreach (Player player in plrs)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine();

            Console.WriteLine("Organized list:");
            GetPlayersWithScoreGreaterThan(plrs, rnd.Next(25, 101));
        }

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
            List<Player> sortedList = plrs;
            sortedList.Sort();

            Console.WriteLine("Score greater than: " + treshold);

            foreach (Player player in sortedList)
            {
                if (player.Score > treshold)
                {
                    Console.WriteLine(player);
                }
            }

            return sortedList;
        }
    }
}
