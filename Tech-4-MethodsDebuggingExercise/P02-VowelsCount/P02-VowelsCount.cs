using System;

namespace P02_VowelsCount
{
    class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowelsCount = CountVowels(input);

            Console.WriteLine(count);
        }

        static int CountVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j] == symbol)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
