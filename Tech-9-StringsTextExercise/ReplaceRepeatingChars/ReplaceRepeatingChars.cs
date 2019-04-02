using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = string.Empty;
            for (int i = 0; i < input.Length - 1; i++)
            {
                char symbol = input[i];
                char nextSymbol = input[i + 1];

                if (symbol != nextSymbol)
                {
                    result += symbol;
                }
                if (i == input.Length -2 && input.Length -1 != input.Length-2)
                {
                    result += nextSymbol;
                }
            }
            Console.WriteLine(result);
        }
    }
}
