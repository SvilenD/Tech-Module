using System;

namespace P08_FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double result = CalculateFactorial(firstNum) / CalculateFactorial(secondNum);

            Console.WriteLine($"{result:f2}");
        }

        static double CalculateFactorial(int num)
        {
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
