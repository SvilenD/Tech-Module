using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace M07._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ',' })
                .Select(x => x.Trim())
                .ToArray();
            var demonsList = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < demons.Length; i++)
            {
                {
                    string demonName = demons[i];

                    double health = 0;

                    var notAllowedSymbols = new char[] { '+', '-', '*', '/', '.' };

                    for (int index = 0; index < demonName.Length; index++)
                    {
                        var symbol = demonName[index];
                        if (!char.IsDigit(symbol) && !notAllowedSymbols.Contains(symbol))
                        {
                            health += demonName[index];
                        }
                    }
                    
                    double damage = 0;

                    string pattern = @"(-?\d+\.?\d*)";
                    var matches = Regex.Matches(demonName, pattern);
                    var nums = matches.ToArray();

                    foreach (var num in nums)
                    {
                        damage += double.Parse(num.Value);
                    }

                    for (int index = 0; index < demonName.Length; index++)
                    {
                        if (demonName[index] == '*')
                        {
                            damage *= 2;
                        }
                        else if (demonName[index] == '/')
                        {
                            damage /= 2;
                        }
                    }

                    demonsList.Add(demonName, new List<double>());
                    demonsList[demonName].Add(health);
                    demonsList[demonName].Add(damage);
                }
            }
            foreach (var kvp in demonsList)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value[0]} health, {kvp.Value[1]:f2} damage");
            }
        }
    }
}