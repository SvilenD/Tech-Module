using System;

namespace P03_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());

            double result = Calculate(oper, firstNum, secondNum);

            Console.WriteLine(result);
        }

        static double Calculate(string oper, double first, double second)
        {
            double result = 0;
            switch (oper)
            {
                case "add":
                    result = first + second;
                    break;
                case "subtract":
                    result = first - second;
                    break;
                case "multiply":
                    result = first * second;
                    break;
                case "divide":
                    result = first / second;
                    break;
            }
            return result;
        }
    }
}