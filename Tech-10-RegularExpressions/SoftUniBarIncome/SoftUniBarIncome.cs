using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z]{1}[a-z]+)%([^|$%.])*<(?<product>\w+)>([^|$%.])*\|(?<count>[0-9]+)\|([^|$%.\d])*(?<price>\d+\.?\d*)\$";
            double totalIncome = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }

                Match inputMatch = Regex.Match(input, pattern);

                if (inputMatch.Success)
                {
                    string name = inputMatch.Groups["name"].Value;
                    string product = inputMatch.Groups["product"].Value;
                    double count = double.Parse(inputMatch.Groups["count"].Value);
                    double totalPrice = double.Parse(inputMatch.Groups["price"].Value) * count;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}