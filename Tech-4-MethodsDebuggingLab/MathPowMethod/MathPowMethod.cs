using System;

namespace MathPowMethod
{
    class MathPowMethod
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            double result = GetPower(num, pow);
            Console.WriteLine(result);
        }

        static double GetPower(double num, double power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}