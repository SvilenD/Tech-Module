using System;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            double average = input.Average();

            string result = string.Join(" ", input.OrderByDescending(x => x).Where(y => y > average).Take(5));

            if (result == string.Empty)
            {
                result = "No";
            }
            Console.WriteLine(result);
        }
    }
}