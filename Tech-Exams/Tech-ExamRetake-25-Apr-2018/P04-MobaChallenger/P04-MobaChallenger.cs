using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playersSkills = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }
                else if (input.Contains(" vs "))
                {
                    var battleData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var firstPlayer = battleData[0].Trim();
                    var secondPlayer = battleData[2].Trim();

                    if (playersSkills.ContainsKey(firstPlayer) && playersSkills.ContainsKey(secondPlayer))
                    {
                        int firstPlayerSkills = playersSkills[firstPlayer].Values.Sum();
                        int secondPlayerSkills = playersSkills[secondPlayer].Values.Sum();

                        var secondPlayerPositions = playersSkills[secondPlayer].Keys.ToList();

                        foreach (var kvp in playersSkills[firstPlayer])
                        {
                            if (secondPlayerPositions.Any(x=>x == kvp.Key))
                            {
                                if (firstPlayerSkills > secondPlayerSkills)
                                {
                                    playersSkills.Remove(secondPlayer);
                                }
                                else if (firstPlayerSkills < secondPlayerSkills)
                                {
                                    playersSkills.Remove(firstPlayer);
                                }
                                break;
                            }
                        }
                    }
                }
                else if (input.Contains(" -> ")) //Add players
                {
                    var data = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = data[0].Trim();
                    var position = data[1].Trim();
                    int skill = int.Parse(data[2].Trim());

                    if (!playersSkills.ContainsKey(name))
                    {
                        playersSkills.Add(name, new Dictionary<string, int>());
                        playersSkills[name].Add(position, skill);
                    }
                    else if (!playersSkills[name].ContainsKey(position))
                    {
                        playersSkills[name].Add(position, skill);
                    }
                    else if (playersSkills[name][position] < skill)
                    {
                        playersSkills[name][position] = skill;
                    }
                }
            }

            foreach (var player in playersSkills.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                long currentPlayerSum = player.Value.Values.Sum();
                Console.WriteLine($"{player.Key}: {currentPlayerSum} skill");

                foreach (var kvp in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }
}