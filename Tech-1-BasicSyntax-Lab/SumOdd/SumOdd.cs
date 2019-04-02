using System;

namespace SumOdd
{
    class SumOdd
    {
        static void Main(string[] args)
        {
            byte count = byte.Parse(Console.ReadLine());
            int number = 1;
            int sum = 0;
            while (count > 0)
            {
                sum += number;
                count--;
                Console.WriteLine(number);
                number += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}