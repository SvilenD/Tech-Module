using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contestsData = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }

                string[] dataInput = input.Split(" -> ").ToArray();

                string user = dataInput[0];
                string contest = dataInput[1];
                int points = int.Parse(dataInput[2]);

                if (!contestsData.ContainsKey(contest))
                {
                    contestsData.Add(contest, new Dictionary<string, int>());
                    contestsData[contest].Add(user, points);
                }
                else if (!contestsData[contest].ContainsKey(user))
                {
                    contestsData[contest].Add(user, points);
                }
                else if (contestsData[contest].ContainsKey(user) && contestsData[contest][user] < points)
                {
                    contestsData[contest][user] = points;
                }
            }

            foreach (var kvp in contestsData)
            {
                string constestName = kvp.Key;
                int participants = kvp.Value.Count;
                Console.WriteLine($"{constestName}: {participants} participants");
                int position = 1;

                foreach (var nKvp in kvp.Value.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    string user = nKvp.Key;
                    int points = nKvp.Value;
                    Console.WriteLine($"{position}. {user} <::> {points}");
                    position++;
                }
            }
            Console.WriteLine("Individual standings:");
            List<string> usernames = new List<string>();

            foreach (var kvp in contestsData)
            {
                foreach (var nKvp in kvp.Value)
                {
                    if (!usernames.Contains(nKvp.Key))
                    {
                        usernames.Add(nKvp.Key);
                    }
                }
            }

            Dictionary<string, int> userData = new Dictionary<string, int>();
            for (int i = 0; i < usernames.Count; i++)
            {
                int totalPoints = 0;
                foreach (var kvp in contestsData)
                {
                    foreach (var nKvp in kvp.Value)
                    {
                        if (nKvp.Key == (usernames[i]))
                        {
                            totalPoints += nKvp.Value;
                        }
                    }
                }
                userData.Add(usernames[i], totalPoints);
            }
            int pos = 1;
            foreach (var kvp in userData.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                string username = kvp.Key;
                int totalPoints = kvp.Value;
                Console.WriteLine($"{pos}. {username} -> {totalPoints}");
                pos++;
            }
        }
    }
}