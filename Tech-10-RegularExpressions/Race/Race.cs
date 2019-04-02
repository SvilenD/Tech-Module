using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] racers = Console.ReadLine().Split(", ");

            string racersPattern = "[A-Za-z]";
            string distancePattern = "[1-9]";

            var driversDistances = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of race")
                {
                    break;
                }

                Regex racersRegex = new Regex(racersPattern);
                MatchCollection racersMatch = racersRegex.Matches(input);

                string currentRacer = string.Empty;
                for (int i = 0; i < racersMatch.Count; i++)
                {
                    currentRacer += racersMatch[i];
                }

                if (!racers.Contains(currentRacer))
                {
                    continue;
                }

                Regex distanceRegex = new Regex(distancePattern);
                MatchCollection distanceMatch = distanceRegex.Matches(input);

                int totalDistance = 0;
                for (int i = 0; i < distanceMatch.Count; i++)
                {
                    totalDistance += int.Parse(distanceMatch[i].Value);
                }

                if (!driversDistances.ContainsKey(currentRacer))
                {
                    driversDistances.Add(currentRacer, totalDistance);
                }

                else 
                {
                    driversDistances[currentRacer] += totalDistance;
                }
            }
            var orderedRacers = new Dictionary<string, int>(driversDistances.OrderByDescending(x => x.Value));

            Console.WriteLine($"1st place: {orderedRacers.First().Key}");
            Console.WriteLine($"2nd place: {orderedRacers.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {orderedRacers.ElementAt(2).Key}");
        }
    }
}