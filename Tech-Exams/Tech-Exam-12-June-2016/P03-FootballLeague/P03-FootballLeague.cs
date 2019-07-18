using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_FootballLeague
{
    class Program       //judge =?! 80/100 !?! 
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();

            var standings = new Dictionary<string, long[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "final")
                {
                    break;
                }

                string[] match = input.Split(new string[] { $"{delimiter}" }, StringSplitOptions.None);

                string host = Reverse(match[1].ToUpper());
                string guest = Reverse(match[3].ToUpper());

                if (!standings.ContainsKey(host))
                {
                    standings.Add(host, new long[] { 0, 0 });
                }
                if (!standings.ContainsKey(guest))
                {
                    standings.Add(guest, new long[] { 0, 0 });
                }

                AddPointsGoals(match[match.Length - 1], host, guest, standings);
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

        private static string Reverse(string input)
        {
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    output = output.Insert(0, input[i].ToString().ToUpper());
                }
                else
                {
                    output = output.Insert(0, input[i].ToString());
                }
            }
            return output;
        }

        static void AddPointsGoals(string input, string host, string guest, Dictionary<string, long[]> standings)
        {
            long hostGoals = 0;
            long guestGoals = 0;

            bool hostScore = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    if (hostScore)
                    {
                        hostGoals = (int)input[i] - '0';
                        standings[host][1] += hostGoals;

                        hostScore = false;
                    }
                    else
                    {
                        guestGoals = (int)input[i] - '0';
                        standings[guest][1] += guestGoals;
                    }
                }
            }
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