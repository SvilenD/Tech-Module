using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string[] reversed = input.Reverse().ToArray();

            foreach (string item in reversed)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}