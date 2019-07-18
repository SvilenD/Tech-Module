using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_InternationalSoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryNamePoints = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine().Split(" -> ");
                if (input[0] == "END")
                {
                    break;
                }
                var country = input[0];
                var name = input[1];
                var points = int.Parse(input[2]);

                if (countryNamePoints.ContainsKey(country) == false)
                {
                    countryNamePoints.Add(country, new Dictionary<string, int>());
                }
                if (countryNamePoints[country].ContainsKey(name) == false)
                {
                    countryNamePoints[country].Add(name, 0);
                }
                countryNamePoints[country][name] += points;
            }

            foreach (var country in countryNamePoints.OrderByDescending(c=>c.Value.Values.Sum()))
            {
                long totalCountryPoints = country.Value.Values.Sum();
                Console.WriteLine($"{country.Key}: {totalCountryPoints}");
                foreach (var name in country.Value)
                {
                    Console.WriteLine($"-- {name.Key} -> {name.Value}");
                }
            }
        }
    }
}
