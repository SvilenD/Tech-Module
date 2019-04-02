using System;

namespace ReverseChars
{
    class ReverseChars
    {
        static void Main(string[] args)
        {
            char[] input = new char[3];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = char.Parse(Console.ReadLine());
            }
            for (int j = input.Length - 1; j >= 0; j--)
            {
                Console.Write(input[j]);
            }
        }
    }
}