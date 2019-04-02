using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBallance = double.Parse(Console.ReadLine());

            double moneySpent = 0;

            while (true)
            {
                string game = Console.ReadLine();

                if (game == "Game Time")
                {
                    break;
                }

                double price = 0;
                switch (game)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
               
                if (currentBallance >= price)
                {
                    currentBallance -= price;
                    moneySpent += price;
                    Console.WriteLine($"Bought {game}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                if (currentBallance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            Console.WriteLine($"Total spent: ${moneySpent:f2}. Remaining: ${currentBallance:f2}");
        }
    }
}
