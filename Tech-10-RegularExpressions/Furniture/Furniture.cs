using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))>>(?<furniture>[A-Za-z\s]+)<<(?<price>\d+.*?\d)!(?<quantity>\d+)\b";
            
            double moneySpent = 0;

            List<string> furnitureList = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }

                Regex regex = new Regex(pattern);

                Match stringMatch = regex.Match(input);
                if (stringMatch.Success)
                {
                    double price = double.Parse(stringMatch.Groups["price"].Value);
                    int quantity = int.Parse(stringMatch.Groups["quantity"].Value);

                    moneySpent += (price * quantity);

                    string furniture = stringMatch.Groups["furniture"].Value;
                    furnitureList.Add(furniture);
                }

            }
            Console.WriteLine("Bought furniture:");
            for (int i = 0; i < furnitureList.Count; i++)
            {
                Console.WriteLine(furnitureList[i]);
            }
            Console.WriteLine($"Total money spend: {moneySpent:f2}");
        }
    }
}
