using System;
using System.Collections.Generic;

namespace P03_RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceNum= int.Parse(Console.ReadLine());

            List<int> fibonacci = new List<int>();

            fibonacci.Add(0);
            fibonacci.Add(1);
            for (int i = 0; i < sequenceNum; i++)
            {
                int next = fibonacci[i] + fibonacci[i + 1];
                fibonacci.Add(next);
            }
            Console.WriteLine(fibonacci[sequenceNum]);
        }
    }
}
