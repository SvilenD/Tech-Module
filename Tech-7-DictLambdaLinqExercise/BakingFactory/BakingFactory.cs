using System;
using System.Collections.Generic;
using System.Linq;

namespace BakingFactory //demo exam nov-18
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestQuality = -1001;  //защото имало constraints от [-100 до 100];

            List<int> input = new List<int>();
            List<int> bestInput = new List<int>();

            while (true)
            {
                int quality = 0;
                try
                {
                    input = Console.ReadLine()
                        .Split("#")
                        .Select(int.Parse)
                        .ToList();
                    for (int i = 0; i < input.Count; i++)
                    {
                        quality += input[i];
                    }
                    if (quality > bestQuality)
                    {
                        bestInput = input;
                        bestQuality = quality;
                    }
                    else if (quality == bestQuality)
                    {
                        double bestAverage = bestInput.Average();
                        double inputAverage = input.Average();

                        if (bestAverage < inputAverage)
                        {
                            bestInput = input;
                        }
                        else if (bestAverage == inputAverage && bestInput.Count > input.Count)
                        {
                            bestInput = input;
                        }
                        bestQuality = quality;
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine($"Best Batch quality: {bestQuality}");
            Console.WriteLine(string.Join(" ", bestInput));
        }
    }
}