using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encrypted = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                int symbolNumber = (int)text[i];
                symbolNumber += 3;

                encrypted += (char)symbolNumber;
            }
            Console.WriteLine(encrypted);
        }
    }
}