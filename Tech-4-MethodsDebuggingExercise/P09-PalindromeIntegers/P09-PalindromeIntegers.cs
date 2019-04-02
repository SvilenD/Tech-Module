using System;

namespace P09_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                CheckIfPalindrome(input);
            }
        }

        static void CheckIfPalindrome(string input)
        {
            for (int index = 0; index < input.Length / 2; index++)
            {
                if (input[index] != input[input.Length - 1 - index])
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
        }
    }
}