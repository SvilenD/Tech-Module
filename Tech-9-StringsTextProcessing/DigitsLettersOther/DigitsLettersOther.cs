using System;

namespace DigitsLettersOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                
                if (char.IsDigit(symbol))
                {
                    digits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    others += symbol;
                }
            }
            Console.WriteLine(digits + Environment.NewLine + letters + Environment.NewLine + others);
        }
    }
}