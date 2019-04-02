using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(double.Parse)
                 .ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 0);
                }
                counts[num]++;
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}