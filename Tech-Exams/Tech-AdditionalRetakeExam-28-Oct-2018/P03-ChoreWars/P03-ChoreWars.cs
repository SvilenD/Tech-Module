using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03_ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int dishesTime = 0;
            int cleaningTime = 0;
            int laundryTime = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "wife is happy")
                {
                    break;
                }

                string dishesPattern = @"\<[a-z0-9]+>";
                Match matchDishes = Regex.Match(input, dishesPattern);
                if (matchDishes.Success)
                {
                    string match = matchDishes.Value;
                    for (int i = 0; i < match.Length; i++)
                    {
                        if (char.IsDigit(match[i]))
                        {
                            dishesTime += int.Parse(match[i].ToString());
                        }
                    }
                    continue;
                }

                string cleaningPattern = @"\[[A-Z0-9]+]";
                Match matchCleaning = Regex.Match(input, cleaningPattern);
                if (matchCleaning.Success)
                {
                    string match = matchCleaning.Value;
                    for (int i = 0; i < match.Length; i++)
                    {
                        if (char.IsDigit(match[i]))
                        {
                            cleaningTime += int.Parse(match[i].ToString());
                        }
                    }
                    continue;
                }

                string laundryPattern = @"\{.+}";
                Match matchLaundry = Regex.Match(input, laundryPattern);
                if (matchLaundry.Success)
                {
                    string match = matchLaundry.Value;
                    for (int i = 0; i < match.Length; i++)
                    {
                        if (char.IsDigit(match[i]))
                        {
                            laundryTime += int.Parse(match[i].ToString());
                        }
                    }
                }
            }

            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            int totalTime = dishesTime + cleaningTime + laundryTime;
            Console.WriteLine($"Total - {totalTime} min.");
        }
    }
}