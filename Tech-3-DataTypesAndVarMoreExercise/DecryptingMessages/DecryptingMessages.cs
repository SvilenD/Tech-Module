using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int numberOfLines = int.Parse(Console.ReadLine());

            string output = string.Empty;
            for (int index = 0; index < numberOfLines; index++)
            {
                char symbol = char.Parse(Console.ReadLine());
                char decrypted = (char)(symbol + key);
                output += decrypted;
            }
            Console.WriteLine(output);
        }
    }
}
