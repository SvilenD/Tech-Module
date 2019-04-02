using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (true)
            {
                string input1 = Console.ReadLine();

                if (input1 == "end of contests")
                {
                    break;
                }
                string[] contestInput = input1.Split(':').ToArray();

                string contestName = contestInput[0];
                string password = contestInput[1];
                contests.Add(contestName, password);
            }

            Dictionary<string, Dictionary<string, int>> candidatesData = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input2 = Console.ReadLine();

                if (input2 == "end of submissions")
                {
                    break;
                }

                string[] contestsData = input2.Split("=>").ToArray();

                string contestName = contestsData[0];
                string password = contestsData[1];
                string username = contestsData[2];
                int score = int.Parse(contestsData[3]);

                if (contests.ContainsKey(contestName) && contests[contestName].Contains(password))
                {
                    if (!candidatesData.ContainsKey(username))
                    {

                        candidatesData.Add(username, new Dictionary<string, int>());
                        candidatesData[username].Add(contestName, score);
                    }
                    else if (!candidatesData[username].ContainsKey(contestName))
                    {
                        candidatesData[username].Add(contestName, score);
                    }
                    else
                    {
                        int contestScore = candidatesData[username][contestName];

                        if (contestScore < score)
                        {
                            candidatesData[username][contestName] = score;
                        }
                    }
                }
            }
            int bestTotal = 0;

            foreach (var kvp in candidatesData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                if (kvp.Value.Values.Sum() >= bestTotal)
                {
                    bestTotal = kvp.Value.Values.Sum();
                    string user = kvp.Key;
                    Console.WriteLine($"Best candidate is {user} with total {bestTotal} points.");
                }
            }

            Console.WriteLine("Ranking: ");

            foreach (var kvp in candidatesData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var nKvp in kvp.Value.OrderByDescending(y => y.Value))
                {
                    string course = nKvp.Key;
                    int score = nKvp.Value;
                    Console.WriteLine($"#  {course} -> {score}");
                }
            }
        }
    }
}