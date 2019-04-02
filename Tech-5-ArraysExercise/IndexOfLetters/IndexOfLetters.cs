using System;
using System.Linq;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabet = AlphabetArray();

            char[] input = Console.ReadLine().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int index = Array.IndexOf(alphabet, input[i]);
                Console.WriteLine($"{input[i]} -> {index}");
            }
        }

        static char[] AlphabetArray()
        {
            int index = 0;
            char[] alphabet = new char[26];
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[index] = i;
                index++;
            }
            return alphabet;
        }
    }
}