using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "3:1")
                {
                    break;
                }
                var command = input[0];
                if (command == "merge")
                {
                    MergeWords(words, input);
                }
                else if (command == "divide")
                {
                    DivideWords(words, input);
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }

        static void DivideWords(List<string> words, string[] input)
        {
            int index = int.Parse(input[1]);
            int parts = int.Parse(input[2]);
            if (parts < 1)
            {
                return;
            }

            int partLength = words[index].Length / parts;
            var wordToDivide = words[index].ToList();
            words.RemoveAt(index);

            for (int i = 0; i < parts; i++)
            {
                if (i < parts - 1)
                {
                    string newWord = string.Join("", wordToDivide.Take(partLength));
                    wordToDivide.RemoveRange(0, partLength);
                    words.Insert(index + i, newWord);
                }
                else
                {
                    string newWord = string.Join("", wordToDivide);
                    words.Insert(index + i, newWord);
                }
            }
        }

        static void MergeWords(List<string> words, string[] input)
        {
            int startIndex = int.Parse(input[1]);
            int endIndex = int.Parse(input[2]);
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= words.Count)
            {
                endIndex = words.Count - 1;
            }
            if (startIndex >= endIndex)
            {
                return;
            }
            int count = 1 + endIndex - startIndex;
            var newWord = words.GetRange(startIndex, count);
            words.RemoveRange(startIndex, count);
            words.Insert(startIndex, string.Join("", newWord));
        }
    }
}
