using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_PopulationAggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryPopulation = new Dictionary<string, Dictionary<string, long>>();
            string counter = "counter";

            while (true)
            {
                string[] input = Console.ReadLine().Split('\\');
                if (input[0] == "stop")
                {
                    break;
                }

                string city = string.Empty;
                string country = string.Empty;
                long population = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    try
                    {
                        population = long.Parse(input[i]);
                    }
                    catch (Exception)
                    {
                        if (input[i][0] >= 65 && input[i][0] <= 90)
                        {
                            country = RemoveProhibitedSymbols(input[i]);
                        }
                        else
                        {
                            city = RemoveProhibitedSymbols(input[i]);
                        }
                    }
                }
                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation.Add(country, new Dictionary<string, long>());
                    countryPopulation[country].Add(city, population);
                    countryPopulation[country].Add(counter, 0);
                }
                else if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country].Add(city, population);
                }
                else
                {
                    countryPopulation[country][city] = population;
                }
                countryPopulation[country][counter]++;
            }

            foreach (var country in countryPopulation.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{country.Key} -> {country.Value[counter]}");
                countryPopulation[country.Key].Remove(counter);
            }

            Dictionary<string, long> cityPopulation = new Dictionary<string, long>();
            foreach (var country in countryPopulation)
            {
                foreach (var city in country.Value)
                {
                    cityPopulation.Add(city.Key, city.Value);
                }
            }

            int count = 0;
            foreach (var city in cityPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{city.Key} -> {city.Value}");
                count++;
                if (count == 3)
                {
                    break;
                }
            }
        }

        static string RemoveProhibitedSymbols(string input)
        {
            string edited = string.Empty;
            char[] prohibited = { '@', '#', '$', '&' };
            for (int i = 0; i < input.Length; i++)
            {
                if (prohibited.Contains(input[i]) || char.IsDigit(input[i]))
                {
                    continue;
                }
                edited += input[i];
            }
            return edited;
        }
    }
}