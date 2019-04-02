using System;
using System.Linq;

namespace M02_CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            decimal leftSum = 0;
            decimal rightSum = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {

                leftSum += numbers[i];
                if (numbers[i] == 0)
                {
                    leftSum *= 0.8m;
                }
            }
            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                rightSum += numbers[i];
                if (numbers[i] == 0)
                {
                    rightSum *= 0.8m;
                }
            }

            if (leftSum < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else if (leftSum > rightSum)
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
