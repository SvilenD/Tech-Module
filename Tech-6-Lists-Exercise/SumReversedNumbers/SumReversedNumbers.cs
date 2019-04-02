using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            double sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                char[] digitString = input[i].ToArray();
                digitString.Reverse();
                
                double num = 0;
                for (int j = digitString.Length - 1; j >= 0; j--)
                {
                    int digit = Convert.ToInt32(digitString[j] - 48);
                    num += digit * Math.Pow(10, j);
            
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}