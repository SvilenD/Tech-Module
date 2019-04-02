using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing // заради числата и спрециалните символи не работи
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\\', '/', '[', ']',' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int index = 0; index < input.Count; index++)
            {
                if (input[index].ToUpper().Equals(input[index]))
                {
                    upperCase.Add(input[index]);
                }
                else if (input[index].ToLower().Equals(input[index]))
                {
                    lowerCase.Add(input[index]);
                }
                else mixedCase.Add(input[index]);
            }

            Console.WriteLine($"Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine($"Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine($"Upper-case: " + string.Join(", ", upperCase));
        }
    }
}