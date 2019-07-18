using System;

namespace P02_BreadFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = 100;
            int coins = 100;

            var events = Console.ReadLine().Split("|");
            for (int i = 0; i < events.Length; i++)
            {
                var input = events[i].Split("-");
                var command = input[0];
                int num = int.Parse(input[1]);

                if (command == "rest")
                {
                    if (energy + num > 100)
                    {
                        energy = 100;
                        num = 100 - energy;
                    }
                    else
                    {
                        energy += num;
                    }
                    Console.WriteLine($"You gained {num} energy.");
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (command == "order")
                {
                    if (energy < 30)  // <= maybe
                    {
                        Console.WriteLine("You had to rest!");
                        energy += 50;
                    }
                    else
                    {
                        energy -= 30;
                        coins += num;
                        Console.WriteLine("You earned {0} coins.", num);
                    }
                }
                else
                {
                    if (coins - num > 0)
                    {
                        coins -= num;
                        Console.WriteLine($"You bought {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command}.");
                        return;
                    }
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}