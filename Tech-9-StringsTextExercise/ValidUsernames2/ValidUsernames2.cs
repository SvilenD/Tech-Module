using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                if (word.Length >= 3 && word.Length <= 16)
                {
                    bool legalChars = true;
                    for (int j = 0; j < word.Length; j++)
                    {
                        char symbol = word[j];
                        if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                        {
                            legalChars = false;
                            break;
                        }
                    }
                    if (legalChars)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
