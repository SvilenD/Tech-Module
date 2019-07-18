using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_EmojiSimulator // fuckin Regex
{
    class Program 
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var code = Console.ReadLine()
                .Split(':')
                .Select(int.Parse)
                .ToArray();
            string codeWord = ":";
            for (int i = 0; i < code.Length; i++)
            {
                codeWord += (char)(code[i]);
            }
            codeWord += ':';

            string pattern = @"(?<= )(?<emoji>:[a-z]{4,}:)(?=[ ,.!?])";
            //string pattern = @"(?<emoji>:[a-z]{4,}:)[ ,.!?]"; 90/100
            //string pattern = @"( )(?<emoji>:[a-z]{4,}:)[ ,.!?]"; 60/100
            //string pattern = @"( )(?<emoji>:[a-z]{4,}:)[ ,.!?]\b"; 20/100

            var matches = Regex.Matches(input, pattern);

            int totalPower = 0;
            if (matches.Count > 0)
            {
                var emojisList = new List<string>();
                foreach (Match match in matches)
                {
                    var emoji = match.Groups["emoji"].ToString();
                    emojisList.Add(emoji);

                    for (int i = 1; i < emoji.Length - 1; i++)
                    {
                        totalPower += emoji[i];
                    }
                }
                if (emojisList.Any(x => x == codeWord))
                {
                    totalPower *= 2;
                }
                Console.WriteLine($"Emojis found: {string.Join(", ", emojisList)}");
            }
            Console.WriteLine($"Total Emoji Power: {totalPower}");
        }
    }
}
