using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z]+)(?<value>.+)(\1)";

            string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            MatchCollection matches = Regex.Matches(input, pattern);

            string toReplace = string.Empty;
            int index = 0;
            foreach (Match match in matches)
            {
                toReplace = match.Groups["value"].Value;
                input = ReplaceFirst(input, toReplace, placeholders[index]);
                //input = input.Replace(toReplace, placeholders[index]);
                index++;
                if (index >= placeholders.Length)
                {
                    break;
                }
            }
            Console.WriteLine(input);
        }
        //A method for replacing first, works like string.Replace.. But only replaces the first result.
        static string ReplaceFirst(string input, string toReplace, string newValue)
        {
            string substringWithOldValue = input.Substring(0, input.IndexOf(toReplace) + toReplace.Length);

            string substringWithNewValue = substringWithOldValue.Replace(toReplace, newValue);

            return substringWithNewValue + input.Substring(substringWithOldValue.Length);
        }
    }
}