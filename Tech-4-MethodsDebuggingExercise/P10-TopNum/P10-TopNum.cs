using System;

namespace P10_TopNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 8; i < num; i++)
            {
                if (TopNum(i))
                {
                    Console.WriteLine(i);
                }

            }
        }

        static bool TopNum(int num)
        {
            int digitSum = 0;
            bool containsOddDigit = false;
            while (num > 0)
            {
                int digit = num % 10;
                digitSum += digit;
                if (num % 2 != 0)
                {
                    containsOddDigit = true;
                }
                num /= 10;
            }
            if (digitSum % 8 == 0 && containsOddDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
