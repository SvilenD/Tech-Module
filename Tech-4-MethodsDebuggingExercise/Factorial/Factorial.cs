using System;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintFactorial(num);
        }

        static void PrintFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int index = 1; index <= num; index++)
            {
                factorial *= index;
            }
            Console.WriteLine(factorial);
        }
    }
}