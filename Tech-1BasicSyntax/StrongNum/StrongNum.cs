using System;

namespace StrongNum
{
    class StrongNum
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int number = num;
            int result = 0;

            while (num > 0)
            {
                int temp = num % 10;
                num = num / 10;
                int sum = 1;
                for (int i = 1; i <= temp; i++)
                {
                    sum *= i;
                }
                result += sum;
            }
            if (result == number)  Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}