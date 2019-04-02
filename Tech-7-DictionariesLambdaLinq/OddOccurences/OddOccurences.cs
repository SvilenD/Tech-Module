using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();

            Dictionary<string, int> wordsIndex = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (wordsIndex.ContainsKey(word))
                {
                    wordsIndex[word]++;
                }
                else
                {
                    wordsIndex.Add(word, 1);
                }
            }

            foreach (var kvp in wordsIndex)
            {
                if (kvp.Value % 2 != 0 )
                {
                    Console.Write($"{ kvp.Key} ");
                }
            }
        }
    }
}