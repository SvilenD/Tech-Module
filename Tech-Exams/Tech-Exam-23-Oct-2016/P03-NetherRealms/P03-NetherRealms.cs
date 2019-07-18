using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonNames = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var data = new Dictionary<string, double[]>();
            char[] excludeFromHealth = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+', '-', '*', '/', '.' };

            for (int index = 0; index < demonNames.Length; index++)
            {
                double damage = 0;
                double health = 0;
                string name = demonNames[index];
                for (int i = 0; i < name.Length; i++)
                {
                    if (!excludeFromHealth.Contains(name[i]))
                    {
                        health += name[i];
                    }
                }
                string pattern = @"(-*\d+\.*\d*)";

                MatchCollection damageNums = Regex.Matches(name, pattern);
                foreach (Match num in damageNums)
                {
                    damage += double.Parse(num.Value);
                }
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == '*')
                    {
                        damage *= 2;
                    }
                    else if (name[i] == '/')
                    {
                        damage /= 2;
                    }
                }

                data.Add(name, new double[] { health, damage });
            }
            foreach (var name in data.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{name.Key} - {name.Value[0]} health, {name.Value[1]:f2} damage");
            }
        }
    }
}
