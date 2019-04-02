using System;

namespace FibonacciNum
{
    class FibonacciNum
    {
        static void Main(string[] args)
        {
            byte numInRow = byte.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciNum(numInRow));
        }

        static uint GetFibonacciNum (byte num)
        {
            uint last = 1;
            uint result = 1;
            uint next = last + result;
            for (int index = 1; index < num ; index++)
            {
                last = result;
                result = next;
                next = last + result;
            }
            return result;
        }
    }
}
