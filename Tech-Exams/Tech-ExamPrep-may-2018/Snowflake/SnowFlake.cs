using System;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                if (i == 0 || i == 4)
                {
                    valid = IsSymbol(input);
                }
                else if (i == 1 || i == 3)
                {
                    valid = IsDigitOrUnderScore(input);
                }
                else
                {
                    valid = IsLetter(input);
                    if (valid)
                    {
                        for (int j = 0; j < input.Length; j++)
                        {
                            char symbol = input[j];
                            if (char.IsLetter(symbol))
                            {
                                count++;
                            }
                        }
                    }
                }
                if (!valid)
                {
                    Console.WriteLine("Invalid");
                    return;
                }
            }
            Console.WriteLine("Valid");
            Console.WriteLine($"{count}");
            
        }

        static bool IsSymbol(string input)
        {
            for (int index = 0; index < input.Length; index++)
            {
                char symbol = input[index];
                if (char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsDigitOrUnderScore(string input)
        {
            for (int index = 0; index < input.Length; index++)
            {
                char symbol = input[index];
                if (!char.IsDigit(symbol) && symbol !='_')
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLetter(string input)
        {
            string pattern = @"^\W+[0-9_]+[A-Za-z]+[0-9_]+\W+$";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}