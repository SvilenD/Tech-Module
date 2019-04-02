using System;
using System.Collections.Generic;

namespace P04_Tribonacci_Sequence
{
    class Program
    {
        static List<int> tribonacci = new List<int> { 1, 1, 2 };

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine(1);
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (num >= 3)
            {
                CalculateTribonacci(num);

                Console.WriteLine(string.Join(" ", tribonacci));
            }
        }

        static void CalculateTribonacci(int num)
        {
            for (int i = 0; i < num - 3; i++)
            {
                int currentNum = tribonacci[i] + tribonacci[i + 1] + tribonacci[i + 2];

                tribonacci.Add(currentNum);
            }
        }
    }
}