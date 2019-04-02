using System;

namespace SpecialNum
{
    class SpecialNum
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                bool result = false;
                int sum = 0;
                int temp = i;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    result = true;
                }
                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}