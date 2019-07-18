using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();

            var standings = new Dictionary<string, long[]>();

            while (true)
            {
                string[] match = Console.ReadLine().Split();

                if (match[0] == "final")
                {
                    break;
                }

                string host = GetTeamName(match[0], delimiter);
                string guest = GetTeamName(match[1], delimiter);

                if (!standings.ContainsKey(host))
                {
                    standings.Add(host, new long[] { 0, 0 });
                }
                if (!standings.ContainsKey(guest))
                {
                    standings.Add(guest, new long[] { 0, 0 });
                }
                string result = match[2];
                AddPointsGoals(result, host, guest, standings);
            }

            int position = 1;
            Console.WriteLine("League standings:");
            foreach (var team in standings.OrderByDescending(x => x.Value[0]).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{position}. {team.Key} {team.Value[0]}");
                position++;
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in standings.OrderByDescending(x => x.Value[1]).ThenBy(y => y.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value[1]}");
            }
        }

        static string GetTeamName(string teamName, string key)
        {
            int firstIndex = teamName.IndexOf(key) + key.Length;
            int secondIndex = teamName.LastIndexOf(key);
            int length = secondIndex - firstIndex;
            string name = teamName.Substring(firstIndex, length);
            return string.Join("", name.ToUpper().Reverse());
        }

        static void AddPointsGoals(string result, string host, string guest, Dictionary<string, long[]> standings)
        {
            string[] score = result.Split(':');
            int hostGoals = int.Parse(score[0]);
            int guestGoals = int.Parse(score[1]);

            standings[host][1] += hostGoals;

            standings[guest][1] += guestGoals;

            if (hostGoals > guestGoals)
            {
                standings[host][0] += 3;
            }
            else if (hostGoals == guestGoals)
            {
                standings[host][0] += 1;
                standings[guest][0] += 1;
            }
            else
            {
                standings[guest][0] += 3;
            }
        }
    }
}