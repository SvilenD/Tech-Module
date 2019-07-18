using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_StarEnigma
{
    class Program
    {
        static char[] letters = new char[] { 'a', 'A', 's', 'S', 't', 'T', 'r', 'R' };
        static List<string> attackedPlanets = new List<string>();
        static List<string> destoyedPlanets = new List<string>();

        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine().ToCharArray();

                string encryped = GetEncryptedMessage(input);
                DecryptMessage(encryped);
            }
            PrintResult();

        }

        static string GetEncryptedMessage(char[] input)
        {
            int count = 0;
            for (int index = 0; index < input.Length; index++)
            {
                if (letters.Any(x => x == input[index]))
                {
                    count++;
                }
            }

            string msg = string.Empty;
            for (int j = 0; j < input.Length; j++)
            {
                msg += (char)(input[j] - count);
            }
            return msg;
        }

        private static void DecryptMessage(string encryped)
        {
            string pattern = @"@(?<name>[A-Za-z]+)([^@:!\->]*):(?<population>[0-9]+)([^@:!\->]*)!(?<type>(A|D))!([^@:!\->]*)->(?<count>[0-9]+)";

            var match = Regex.Match(encryped, pattern);
            if (match.Success)
            {
                string name = match.Groups["name"].Value;
                //int population = int.Parse(match.Groups["population"].Value);
                var type = match.Groups["type"].Value;
                //int count = int.Parse(match.Groups["count"].Value);
                if (type == "A")
                {
                    attackedPlanets.Add(name);
                }
                else
                {
                    destoyedPlanets.Add(name);
                }
            }
        }

        private static void PrintResult()
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }
            
            Console.WriteLine($"Destroyed planets: {destoyedPlanets.Count}");
            foreach (var planet in destoyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}