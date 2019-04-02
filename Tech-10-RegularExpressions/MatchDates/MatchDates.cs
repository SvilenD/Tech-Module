using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection matchedDates = Regex.Matches(input, regex);

            foreach (Match date in matchedDates)
            {
                var dateMatched = date.Groups["day"].Value;
                var monthMatched = date.Groups["month"].Value;
                var yearMatched = date.Groups["year"].Value;

                Console.WriteLine($"Day: {dateMatched}, Month: {monthMatched}, Year: {yearMatched}");
            }
        }
    }
}
