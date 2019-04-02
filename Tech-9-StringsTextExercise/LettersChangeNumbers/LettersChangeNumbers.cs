using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char tab = Convert.ToChar(9);   // TAB 
            char[] split = { ' ', tab };
            string[] input = Console.ReadLine().Split(split, StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                int length = word.Length;

                string numString = word.Substring(1, length - 2);
                decimal number = decimal.Parse(numString);

                if (word[0] >= 'A' && word[0] <= 'Z')
                {
                    decimal divider = word[0] - 'A' + 1;

                    sum += number / divider;
                }

                else
                {
                    decimal alphabetPosition = word[0] - 'a' + 1;

                    sum += number * alphabetPosition;
                }

                if (word[length - 1] >= 'A' && word[length - 1] <= 'Z')
                {
                    decimal subtract = word[length -1] - 'A' + 1;

                    sum -= subtract;
                }

                else 
                {
                    decimal add = word[length -1] - 'a' + 1;

                    sum += add;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
