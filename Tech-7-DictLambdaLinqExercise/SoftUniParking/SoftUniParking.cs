using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Dictionary<string, string> regPlatesIndex = new Dictionary<string, string>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string username = input[1];
                if (input[0] == "register")
                {
                string licensePlateNumber = input[2];
                    if (regPlatesIndex.ContainsKey(username))
                    {
                        licensePlateNumber = regPlatesIndex[username];

                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        regPlatesIndex.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (!regPlatesIndex.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        regPlatesIndex.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in regPlatesIndex)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}