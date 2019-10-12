using System;

namespace MyInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IHasScore equalChecker = null;
            Random rnd = new Random();
            IHasScore[] hasScores = new IHasScore[10];

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    hasScores[i] = new Player(DefPlayerName(rnd.Next(3)),
                        rnd.Next(6));
                }
                else if (i % 2 != 0)
                {
                    hasScores[i] = new Hotel(
                        DefHotelName(rnd.Next(3)), DefDescription(rnd.Next(3)),
                        rnd.Next(1,11), rnd.Next(3), rnd.Next(6));
                }
            }

            foreach (IHasScore item in hasScores)
            {

                Console.WriteLine($"{item}");
                Console.WriteLine();
                Console.WriteLine($"Is {equalChecker} the same as {item}? " +
                    $"{item.Equals(equalChecker)}");

                equalChecker = item;

                Console.WriteLine();
            }

        }

        // static methods to define rndm names and descriptions
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

        private static string DefHotelName(int rnd)
        {
            switch (rnd)
            {
                case 0:
                    {
                        return "Git";
                    }

                case 1:
                    {
                        return "Juilo";
                    }

                case 2:
                    {
                        return "Rasca";
                    }

                default:
                    return "OutOfNames";
            }
        }

        private static string DefDescription(int rnd)
        {
            switch (rnd)
            {
                case 0:
                    {
                        return "Lovely Place";
                    }

                case 1:
                    {
                        return "Could be worse";
                    }

                case 2:
                    {
                        return "Junkie paradise";
                    }

                default:
                    return "OutOfWords_LeL";
            }
        }
    }
}
