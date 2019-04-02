using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b([A-Z]{1}[a-z]+)\s([A-Z]{1}[a-z]+)\b";

            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            Console.WriteLine(string.Join(" ", matchedNames));
        }
    }
}
