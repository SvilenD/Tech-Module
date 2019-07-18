using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            var firstPart = input[0];
            var firstPattern = @"([#$%*&]+)(?<first>[A-Z]+)(\1)";

            MatchCollection firstMatches = Regex.Matches(firstPart, firstPattern);

            var letters = string.Empty;
            foreach (Match match in firstMatches)
            {
                letters += match.Groups["first"].Value;
            }

            int[] startLettersNumbers = new int[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                startLettersNumbers[i] = (int)(letters[i]);
            }

            var secondPart = input[1];
            var secondPattern = @"\d{2}:\d{2}";

            MatchCollection secondMatch = Regex.Matches(secondPart, secondPattern);

            var words = new Dictionary<char, int>();

            foreach (Match match in secondMatch)
            {
                var current = match.Value.Split(':');
                int num = int.Parse(current[0]);
                int length = int.Parse(current[1]) + 1;

                if (startLettersNumbers.Contains(num) && length > 1 && length < 21)
                {
                    char startLetter = (char)num;
                    if (!words.ContainsKey(startLetter))
                    {
                        words.Add(startLetter, length);
                    }
                }
            }

            var thirdPart = input[2].Split();

            for (int i = 0; i < thirdPart.Length; i++)
            {
                var currentWord = thirdPart[i];

                if (words.ContainsKey(currentWord[0]))
                {
                    var word = words.FirstOrDefault(x => x.Key == currentWord[0]);
                    if (word.Value == currentWord.Length)
                    {
                        Console.WriteLine(currentWord);
                    }
                }
            }
        }
    }
}