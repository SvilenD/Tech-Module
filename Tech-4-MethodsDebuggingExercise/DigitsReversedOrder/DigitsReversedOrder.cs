using System;

namespace DigitsReversedOrder
{
    class DigitsReversedOrder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = GetDigitsInReversedOrder(input);
            Console.WriteLine(output);
        }

        private static string GetDigitsInReversedOrder(string input)
        {
            string reversed = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                reversed += input[(input.Length -1) - i];
            }
            
            return reversed;
        }
    }
}