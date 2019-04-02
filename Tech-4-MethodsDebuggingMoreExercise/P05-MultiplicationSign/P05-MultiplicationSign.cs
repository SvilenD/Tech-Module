using System;

namespace P05_MultiplicationSign
{
    class Program
    {

        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            PrintSign(firstNum, secondNum, thirdNum);
        }

        static void PrintSign(double first, double second, double third)
        {
            if (first == 0 || second == 0 || third == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((first < 0 ^ second < 0 ^ third < 0) || (first <0 && second <0 && third <0)) 
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}