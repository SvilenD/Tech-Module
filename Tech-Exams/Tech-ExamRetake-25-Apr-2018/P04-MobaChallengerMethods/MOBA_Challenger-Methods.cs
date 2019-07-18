using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static Dictionary<string, Dictionary<string, int>> playersData = new Dictionary<string, Dictionary<string, int>>();

        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }
                else if (input.Contains(" -> "))
                {
                    var dataInput = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    addPlayersData(dataInput);
                }
                else if (input.Contains(" vs "))
                {
                    var battleData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    EditData(battleData);
                }
            }

            PrintResult();
        }

        public static void addPlayersData(string[] dataInput)
        {
            string name = dataInput[0].Trim();
            string position = dataInput[1].Trim();
            int skill = int.Parse(dataInput[2].Trim());

            if (!playersData.ContainsKey(name))
            {
                playersData.Add(name, new Dictionary<string, int>());
                playersData[name].Add(position, skill);
            }
            else if (!playersData[name].ContainsKey(position))
            {
                playersData[name].Add(position, skill);
            }
            else if (playersData[name][position] < skill)
            {
                playersData[name][position] = skill;
            }
        }

        public static void EditData(string[] battleData)
        {
            var firstPlayer = battleData[0].Trim();
            var secondPlayer = battleData[2].Trim();

            if (playersData.ContainsKey(firstPlayer) && playersData.ContainsKey(secondPlayer))
            {
                int firstPlayerSkills = playersData[firstPlayer].Values.Sum();
                int secondPlayerSkills = playersData[secondPlayer].Values.Sum();

                var secondPlayerPositions = playersData[secondPlayer].Keys.ToList();

                foreach (var kvp in playersData[firstPlayer])
                {
                    if (secondPlayerPositions.Any(x => x == kvp.Key))
                    {
                        if (firstPlayerSkills > secondPlayerSkills)
                        {
                            playersData.Remove(secondPlayer);
                        }
                        else if (firstPlayerSkills < secondPlayerSkills)
                        {
                            playersData.Remove(firstPlayer);
                        }
                        break;
                    }
                }
            }
        }

        public static void PrintResult()
        {
            foreach (var player in playersData.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                long totalSkills = player.Value.Values.Sum();
                Console.WriteLine($"{player.Key}: {totalSkills} skill");

                foreach (var nKvp in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    string position = nKvp.Key;
                    int skill = nKvp.Value;
                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }
    }
}