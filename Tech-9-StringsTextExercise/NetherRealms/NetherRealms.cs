using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = new Dictionary<string, double[]>();

            var input = Console.ReadLine()
                .Split(new char[] { ',' })
                .Select(x => x.Trim())
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                string name = input[i];
                double health = SumCharacters(name);
                double damage = CalculateDamage(name);

                demons.Add(name, new double[] { health, damage });
            }

            foreach (var name in demons.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{name.Key} - {name.Value[0]} health, {name.Value[1]:f2} damage");
            }
        }

        private static double CalculateDamage(string input)
        {
            double damage = 0;

            string pattern = @"(-?\d+\.?\d*)";
            var matches = Regex.Matches(input, pattern);

            foreach (Match num in matches)
            {
                damage += double.Parse(num.Value);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    damage *= 2;
                }
                else if (input[i] == '/')
                {
                    damage /= 2;
                }
            }
            return damage;
        }

        static double SumCharacters(string name)
        {
            var notAllowedSymbols = new char[] { '+', '-', '*', '/', '.' };
            double sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                char symbol = name[i];
                if (!char.IsDigit(symbol) && !notAllowedSymbols.Contains(symbol))
                {
                    sum += symbol;
                }
            }
            return sum;
        }
    }
}