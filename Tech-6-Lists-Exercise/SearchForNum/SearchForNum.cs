using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> numsTaken = input.Take(command[0]).ToList();
            //for (int i = 0; i < command[0]; i++)
            //{
            //    numsTaken.Add(input[i]);
            //}

            int numbersToRemove = command[1];
            numsTaken.RemoveRange(0, numbersToRemove);

            int numToFind = command[2];

            if (numsTaken.Contains(numToFind))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}