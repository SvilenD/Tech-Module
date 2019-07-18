using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSum = int.MinValue;
            var bestBatch = new List<int>();
            while (true)
            {
                var input = Console.ReadLine().Split("#");
                if (input[0] == "Bake It!")
                {
                    break;
                }
                var numbers = input.Select(int.Parse).ToArray();
                int sum = numbers.Sum();
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestBatch = numbers.ToList();
                }
                else if (sum == maxSum)
                {
                    double average = numbers.Average();
                    double bestAverage = bestBatch.Average();
                    if (average > bestAverage)
                    {
                        maxSum = sum;
                        bestBatch = numbers.ToList();
                    }
                    else if (average == bestAverage && bestBatch.Count > numbers.Length)
                    {
                        maxSum = sum;
                        bestBatch = numbers.ToList();
                    }
                }
            }
            Console.WriteLine($"Best Batch quality: {maxSum}");
            Console.WriteLine(string.Join(" ",bestBatch));
        }
    }
}
