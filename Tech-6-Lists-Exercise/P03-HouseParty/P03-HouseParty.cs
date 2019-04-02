using System;
using System.Collections.Generic;

namespace P03_HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numOfLines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];

                if (input[2] == "not" && guests.Contains(name))
                {
                    guests.Remove(name);
                }
                else if (input[2] == "not" && !guests.Contains(name))
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
                else if (guests.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    guests.Add(name);
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}