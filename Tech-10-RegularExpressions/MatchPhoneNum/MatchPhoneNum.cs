using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(?<!\S)\+359(\s|-)(2)\1(\d{3})\1(\d{4})\b";

            var phoneNumbers = Console.ReadLine();

            MatchCollection matchedPhones = Regex.Matches(phoneNumbers, regex);

            //var matchedPhones = phoneMatches
            //    .Cast<Match>()
            //    .Select(x => x.Value.Trim())
            //    .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
