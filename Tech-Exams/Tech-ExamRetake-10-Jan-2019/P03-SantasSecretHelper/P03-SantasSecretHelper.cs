using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            var kids = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var code = input.Select(x => x - key).Select(y => (char)y).ToList();
                var msg = string.Join("", code);
                string pattern = @"@(?<name>[A-Za-z]+)[^-@!:>]*!(?<behavior>(G))!";
                Match match = Regex.Match(msg, pattern);
                var name = string.Empty;
                if (match.Success)
                {
                    name = match.Groups["name"].Value;
                    kids.Add(name);
                }
            }

            foreach (var name in kids)
            {
                Console.WriteLine(name);
            }
        }
    }
}