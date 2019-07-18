using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ArrivingInKathmandu
{
    class Program
    {
        static void Main()
        {
            var symbolsToRemove = new char[] { '!', '@', '#', '$', '?' };

            string pattern = @"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>[0-9]+)(<{2})(?<geo>.+)$";

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Last note")
                {
                    break;
                }

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var name = match.Groups["name"].Value;
                    var nameOfMountain = new StringBuilder();
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!symbolsToRemove.Contains(name[i]))
                        {
                            nameOfMountain.Append(name[i]);
                        }
                    }

                    int length = int.Parse(match.Groups["length"].Value);

                    var geohashcode = match.Groups["geo"].Value;

                    if (geohashcode.Length == length)
                    {
                        Console.WriteLine($"Coordinates found! {nameOfMountain} -> {geohashcode}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}