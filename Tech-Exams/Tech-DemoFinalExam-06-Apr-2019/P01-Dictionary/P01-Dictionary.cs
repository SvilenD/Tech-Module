using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            var input = Console.ReadLine().Split(" | ");

            for (int i = 0; i < input.Length; i++)
            {
                var wordDefinition = input[i].Split(": ");

                var word = wordDefinition[0];
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }

                var definition = wordDefinition[1];
                dictionary[word].Add(definition);
            }

            var words = Console.ReadLine().Split(" | ");

            for (int i = 0; i < words.Length; i++)
            {
                if (dictionary.ContainsKey(words[i]))
                {
                    Console.WriteLine(words[i]);
                    foreach (var definition in dictionary[words[i]].OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" -{definition}");
                    }

                }
            }

            var command = Console.ReadLine();
            if (command == "List")
            {
                var listOfWords = new List<string>();
                foreach (var word in dictionary.OrderBy(x => x.Key))
                {
                    listOfWords.Add(word.Key);
                }
                Console.WriteLine(string.Join(" ", listOfWords));
            }
        }
    }
}
