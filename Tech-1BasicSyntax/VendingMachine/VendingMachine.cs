using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = 0;
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "start")
                {
                    break;
                }

                decimal coin = decimal.Parse(input);
                switch (coin)
                {
                    case 0.1m:
                    case 0.2m:
                    case 0.5m:
                    case 1.0m:
                    case 2.0m: money += coin; break;
                    default: Console.WriteLine($"Cannot accept { coin}"); break;
                }
            }

            while (money >= 0)
            {
                string product = Console.ReadLine().ToLower();

                if (product == "end")
                {
                    break;
                }

                decimal price = 0;

                switch (product)
                {
                    case "nuts": price = 2.0m; break;
                    case "water": price = 0.7m; break;
                    case "crisps": price = 1.5m; break;
                    case "soda": price = 0.8m; break;
                    case "coke": price = 1.0m; break;
                    default:
                        break;
                }

                if (price == 0)
                {
                    Console.WriteLine("Invalid product");
                }
                else if (money >= price)
                {
                    money -= price;
                    Console.WriteLine($"Purchased {product}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}