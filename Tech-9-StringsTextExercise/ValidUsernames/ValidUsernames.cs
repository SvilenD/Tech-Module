using System;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                string pattern = @"^(\w|-){3,16}$";
                Match match = Regex.Match(word, pattern);
                if (match.Success)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}