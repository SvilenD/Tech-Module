namespace P03_CharsInRange
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static List<char> charSequence = new List<char>();

        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            GetCharsInRange(first, second);
            Console.WriteLine(string.Join(' ', charSequence));
        }

        static void GetCharsInRange(char first, char second)
        {
            if (first < second)
            {
                for (int i = first + 1; i < second; i++)
                {
                    char symbol = (char)i;
                    charSequence.Add(symbol);
                }
            }
            else
            {
                for (int i = second + 1; i < first; i++)
                {
                    char symbol = (char)i;
                    charSequence.Add(symbol);
                }
            }
        }
    }
}
