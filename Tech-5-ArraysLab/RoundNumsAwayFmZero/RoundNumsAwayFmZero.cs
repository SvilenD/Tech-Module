using System;
using System.Linq;

namespace RoundNumsAwayFmZero
{
    class RoundNumsAwayFmZero
    {
        static void Main(string[] args)
        {
            decimal[] array = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            for(int index = 0; index < array.Length; index++)
            {
                decimal output = Math.Round(array[index], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array [index]} => {output}");
            }
        }
    }
}