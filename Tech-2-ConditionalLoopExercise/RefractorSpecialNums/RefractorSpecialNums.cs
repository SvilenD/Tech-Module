using System;

namespace RefractorSpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            
            for (int index = 1; index <= endNum; index++)
            {
                bool special = false;
                int sum = 0;
                int num = index;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if ((sum == 5) || (sum == 7) || (sum == 11))
                {
                    special = true;
                }
                Console.WriteLine($"{index} -> {special}");
            }
        }
    }
}