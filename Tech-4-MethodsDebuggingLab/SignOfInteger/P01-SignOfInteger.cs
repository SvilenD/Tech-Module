using System;

namespace SignOfInteger
{
    class SignOfInteger
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintIntegerSign(num);
        }

        static void PrintIntegerSign(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else Console.WriteLine($"The number {num} is positive.");
        }
    }
}
