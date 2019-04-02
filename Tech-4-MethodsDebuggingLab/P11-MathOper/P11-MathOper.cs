using System;

namespace P11_MathOper
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            var oper = char.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());

            double result = Calculate(firstNum, oper, secondNum);

            Console.WriteLine(result);
        }

        static double Calculate(double first, char oper, double second)
        {
            double result = 0;
            switch (oper)
            {
                case '+': result = first + second;
                    break;
                case '-': result = first - second;
                    break;
                case '*': result = first * second;
                    break;
                case '/': result = first / second;
                    break;
            }
            return result;
        }
    }
}