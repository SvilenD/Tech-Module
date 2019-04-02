using System;
using System.Collections.Generic;

namespace SplitByWordCasing2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",;:.!()\"'\\/[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int index = 0; index < input.Length; index++)
            {
                string currentWord = input[index];
                if (IsUpper(currentWord))
                {
                    upperCase.Add(input[index]);
                }
                else if (IsLower(currentWord))
                {
                    lowerCase.Add(input[index]);
                }
                else
                {
                    mixedCase.Add(currentWord);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }

        static bool IsUpper(string currentWord)
        {
            bool upper = true;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if(Convert.ToInt32(currentWord[i]) < 65 || Convert.ToInt32(currentWord[i]) > 90)
                {
                    upper = false;
                }
            }
            return upper;
        }

        static bool IsLower(string currentWord)
        {
            foreach (char symbol in currentWord)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}