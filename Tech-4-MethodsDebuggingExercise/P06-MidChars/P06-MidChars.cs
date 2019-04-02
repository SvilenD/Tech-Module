using System;

namespace P06_MidChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMidChars(input);
        }

        static void PrintMidChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        }
    }
}
