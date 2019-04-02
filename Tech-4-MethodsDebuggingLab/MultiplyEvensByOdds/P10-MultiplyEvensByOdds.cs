using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {

        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = MultiplyEvensOddsSum(number);
            Console.WriteLine(result);
        }

        static int MultiplyEvensOddsSum(int sum)
        {
            int multiplied = SumEvenDigits(sum) * SumOddDigits(sum);
            return multiplied;
        }

        static int SumEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }

        static int SumOddDigits (int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }

    }
}