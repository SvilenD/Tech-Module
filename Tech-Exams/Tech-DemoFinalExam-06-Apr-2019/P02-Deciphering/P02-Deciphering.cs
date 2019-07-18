using System;
using System.Linq;
using System.Text;

namespace P02_Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            var encrypted = Console.ReadLine();
            var substrings = Console.ReadLine().Split();

            var allowedSymbols = new char[] { '{', '}', '|', '#' };

            var decoded = new StringBuilder();
            for (int i = 0; i < encrypted.Length; i++)
            {
                if (encrypted[i] < 100 && !allowedSymbols.Contains(encrypted[i]))
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
                decoded.Append((char)(encrypted[i] - 3));
            }

            decoded.Replace(substrings[0], substrings[1]);
            Console.WriteLine(decoded);
        }
    }
}