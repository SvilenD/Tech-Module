using System;

namespace P05_AddSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum);
            int result = Subtract(sum, thirdNum);

            Console.WriteLine(result);
        }

        static int Sum (int first, int second)
        {
            return first + second;
        }

        static int Subtract(int sum, int third)
        {
            return sum - third;
        }
    }
}
