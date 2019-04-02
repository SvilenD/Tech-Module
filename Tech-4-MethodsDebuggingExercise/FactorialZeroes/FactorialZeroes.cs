using System;
using System.Numerics;

namespace FactorialZeroes
{
    class FactorialZeroes
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(num));
        }

        static int CalculateFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int index = 1; index <= num; index++)
            {
                factorial *= index;
            }
            string convFactorial = Convert.ToString(factorial);

            int output = CountZeroes(convFactorial);
            return output;
        }
        static int CountZeroes(string convFact)
        {
            int count = 0;
            for (int index = convFact.Length - 1; index >= 0 ; index--)
            {
                if (convFact[index] == '0')
                {
                    count++;
                }
                else break;
            }
            return count;
        }
    }
}
