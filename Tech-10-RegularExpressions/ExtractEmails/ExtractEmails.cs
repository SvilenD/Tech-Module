using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<!\S)[A-Za-z0-9]+[.-]*[\w]+@[a-z-]+.[a-z]+?[.][a-z]*\b";

            string input = Console.ReadLine();

            MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
