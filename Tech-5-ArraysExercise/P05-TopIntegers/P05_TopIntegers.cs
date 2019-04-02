using System;
using System.Linq;

namespace P05_TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                bool top = true;
                int number = input[i];
                for (int j = i + 1; j < input.Length; j++)
                {
                    int nextNum = input[j];
                    if (number <= nextNum)
                    {
                        top = false;
                        break;
                    }
                }
                if (top)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
