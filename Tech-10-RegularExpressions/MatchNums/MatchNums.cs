using System;
using System.Text.RegularExpressions;


namespace MatchNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();

            MatchCollection matchedNums = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(' ', matchedNums));
        }
    }
}