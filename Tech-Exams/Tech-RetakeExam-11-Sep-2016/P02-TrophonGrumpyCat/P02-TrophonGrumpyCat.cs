using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_TrophonGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceRatings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string typePriceRating = Console.ReadLine();

            long leftSum = 0;
            long rightSum = 0;

            var leftPart = priceRatings.GetRange(0, entryPoint);
            int rightPartCount = priceRatings.Count - (entryPoint + 1);
            var rightPart = priceRatings.GetRange(entryPoint + 1, rightPartCount);

            if (typeOfItems == "cheap")
            {
                leftPart = leftPart.Where(x => x < priceRatings[entryPoint]).ToList();
                rightPart = rightPart.Where(x => x < priceRatings[entryPoint]).ToList();
                if (typePriceRating == "positive")
                {
                    leftSum = CalculateSum(leftPart.Where(x => x > 0).ToList());
                    rightSum = CalculateSum(rightPart.Where(x => x > 0).ToList());
                }
                else if (typePriceRating == "negative")
                {
                    leftSum = CalculateSum(leftPart.Where(x => x < 0).ToList());
                    rightSum = CalculateSum(rightPart.Where(x => x < 0).ToList());
                }
                else //all
                {
                    leftSum = CalculateSum(leftPart);
                    rightSum = CalculateSum(rightPart);
                }
            }
            else if (typeOfItems == "expensive")
            {
                leftPart = leftPart.Where(x => x >= priceRatings[entryPoint]).ToList();
                rightPart = rightPart.Where(x => x >= priceRatings[entryPoint]).ToList();

                if (typePriceRating == "positive")
                {
                    leftSum = CalculateSum(leftPart.Where(x => x > 0).ToList());
                    rightSum = CalculateSum(rightPart.Where(x => x > 0).ToList());
                }
                else if (typePriceRating == "negative")
                {
                    leftSum = CalculateSum(leftPart.Where(x => x < 0).ToList());
                    rightSum = CalculateSum(rightPart.Where(x => x < 0).ToList());
                }
                else //all
                {
                    leftSum = CalculateSum(leftPart);
                    rightSum = CalculateSum(rightPart);
                }
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        static long CalculateSum(List<int> items)
        {
            long sum = 0;
            for (int i = 0; i < items.Count; i++)
            {
                sum += items[i];
            }
            return sum;
        }
    }
}