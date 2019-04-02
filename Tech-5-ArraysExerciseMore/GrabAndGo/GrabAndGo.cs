using System;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int numToFind = int.Parse(Console.ReadLine());

            long sum = 0;
            if (input.Contains(numToFind))
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] == numToFind)
                    {
                        for (int nums = 0; nums < i; nums++)
                        {
                            sum += input[nums];
                        }
                        break;
                    }
                }
                Console.WriteLine(sum);
            }
            else Console.WriteLine("No occurrences were found!");
        }
    }
}