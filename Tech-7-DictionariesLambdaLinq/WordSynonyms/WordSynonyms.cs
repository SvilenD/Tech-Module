using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < pairs; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsDict.ContainsKey(word))
                {
                    List<string> synonymsList = new List<string>();
                    wordsDict.Add(word, synonymsList);
                }

                wordsDict[word].Add(synonym);
            }

            foreach (var kvp in wordsDict)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}