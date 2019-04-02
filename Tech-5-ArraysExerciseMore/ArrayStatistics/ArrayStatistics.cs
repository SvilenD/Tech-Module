using System;
using System.Linq;

namespace ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            double average = sum / (1.0 * input.Length);
            int min = input.Min();
            int max = input.Max();

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

        }
    }
}
