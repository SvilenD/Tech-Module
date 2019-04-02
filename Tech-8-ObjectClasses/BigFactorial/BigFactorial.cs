using System;
using System.Numerics;

namespace BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int num = 1; num <= factorial; num++)
            {
                result *= num;
            }
            Console.WriteLine(result);
        }
    }
}