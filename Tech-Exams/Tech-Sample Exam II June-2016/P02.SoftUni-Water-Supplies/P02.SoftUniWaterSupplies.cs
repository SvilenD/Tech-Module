using System;
using System.Linq;

namespace P02.SoftUni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalWater = double.Parse(Console.ReadLine());
            double[] bottlesContent = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double bottleCapacity = double.Parse(Console.ReadLine());

            if (totalWater % 2 == 0)
            {
                for (int index = 0; index < bottlesContent.Length; index++)
                {
                    if (bottleCapacity - bottlesContent[index] > totalWater)
                    {
                        Console.WriteLine("We need more water!");
                        Console.WriteLine($"Bottles left: {bottlesContent.Length - index}");

                        int count = bottlesContent.Length - index;
                        int[] empty = Enumerable.Range(index, count).ToArray();
                        Console.WriteLine($"With indexes: {string.Join(", ", empty)}");

                        double extraWaterNeeded = (bottlesContent.Length * bottleCapacity) - (bottlesContent.Sum() + totalWater);
                        Console.WriteLine($"We need {extraWaterNeeded} more liters!");
                        return;
                    }

                    else
                    {
                        totalWater -= bottleCapacity - bottlesContent[index];
                        bottlesContent[index] = bottleCapacity;
                    }
                }
            }
            else
            {
                for (int index = bottlesContent.Length - 1; index >= 0; index--)
                {
                    if (bottleCapacity - bottlesContent[index] > totalWater)
                    {
                        Console.WriteLine("We need more water!");
                        Console.WriteLine($"Bottles left: {index + 1}");

                        int count = index + 1;
                        int[] empty = Enumerable.Range(0, count).Reverse().ToArray();
                        Console.WriteLine($"With indexes: {string.Join(", ", empty)}");

                        double extraWaterNeeded = (bottlesContent.Length * bottleCapacity) - (bottlesContent.Sum() + totalWater);
                        Console.WriteLine($"We need {extraWaterNeeded} more liters!");
                        return;
                    }

                    else
                    {
                        totalWater -= bottleCapacity - bottlesContent[index];
                        bottlesContent[index] = bottleCapacity;
                    }
                }
            }
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {totalWater}l.");
        }
    }
}