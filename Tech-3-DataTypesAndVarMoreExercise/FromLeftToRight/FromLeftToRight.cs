using System;
using System.Linq;

namespace FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                long[] input = Console.ReadLine()
                    .Split(" ")
                    .Select(long.Parse)
                    .ToArray();

                long number = Math.Abs(Math.Max(input[0], input[1]));

                long sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
