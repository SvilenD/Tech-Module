using System;
using System.Collections.Generic;
using System.Linq;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            foreach (char symbol in input.Where(x => x != ' '))
            {
                if (!charsCount.ContainsKey(symbol))
                {
                    charsCount.Add(symbol, 0);
                }
                charsCount[symbol]++;
            }

            foreach (var kvp in charsCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}