using System;

namespace OddNum
{
    class OddNum
    {
        static void Main(string[] args)
        {
            bool oddNum = true;
            while (oddNum)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 != 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    oddNum = false;
                }
                else Console.WriteLine("Please write an odd number.");
            }
        }
    }
}