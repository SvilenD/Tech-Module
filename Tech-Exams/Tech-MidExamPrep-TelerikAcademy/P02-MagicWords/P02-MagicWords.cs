using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            var words = new List<string>();
            for (int i = 0; i < length; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int index = words[i].Length % (length + 1);
                words.Insert(index, words[i]);
                if (index < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.Remove(words[i]);
                }
            }
            var maxLength = 0;
            foreach (var word in words)
            {
                if (maxLength < word.Length)
                {
                    maxLength = word.Length;
                }
            }
            //var maxLength = words.Max(x => x.Length);
            var result = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (i < word.Length)
                    {
                        result.Append(word[i]);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
