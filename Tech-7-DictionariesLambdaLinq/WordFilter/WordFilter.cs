using System;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine()
                .Split(" ")
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (string word in wordsInput)
            {
                Console.WriteLine(word);
            }
        }
    }
}
