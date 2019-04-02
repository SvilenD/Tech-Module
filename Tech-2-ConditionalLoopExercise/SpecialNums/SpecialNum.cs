using System;

namespace SpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNum; i++ )
            {
                int num = i;
                int sum = 0;
                bool special = false;
                
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}