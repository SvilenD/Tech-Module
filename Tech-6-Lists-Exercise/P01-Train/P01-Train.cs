using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                else if (input.Contains("Add"))
                {
                    int number = int.Parse(input.Split().Last());
                    wagons.Add(number);
                }

                else
                {
                    int number = int.Parse(input);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + number <= maxCapacity)
                        {
                            wagons[i] += number;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}