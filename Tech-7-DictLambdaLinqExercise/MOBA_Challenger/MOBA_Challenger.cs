using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersData = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }
                else if (input.Contains(" -> "))
                {
                    string[] dataInput = input.Split(" -> ").ToArray();

                    DataEntry(dataInput, playersData);
                }
                else if (input.Contains(" vs "))
                {
                    string[] dataEdit = input.Split(" vs ").ToArray();

                    EditData(dataEdit, playersData);
                }
            }

            foreach (var kvp in playersData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                int totalSkill = 0;
                string player = kvp.Key;
                foreach (var nKvp in kvp.Value)
                {
                    totalSkill += nKvp.Value;
                }
                Console.WriteLine($"{player}: {totalSkill} skill");

                foreach (var nKvp in kvp.Value.OrderByDescending(x => x.Value))
                {
                    string position = nKvp.Key;
                    int skill = nKvp.Value;
                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }

        static void EditData(string[] dataEdit, Dictionary<string, Dictionary<string, int>> playersData)
        {
            string player1 = dataEdit[0];
            string player2 = dataEdit[1];

            if (playersData.ContainsKey(player1) && playersData.ContainsKey(player2))
            {
                List<string> player1Positions = new List<string>();
                bool battle = false;
                int player1Skills = 0;
                int player2Skills = 0;

                foreach (var kvp in playersData[player1])
                {
                    player1Positions.Add(kvp.Key);
                    player1Skills += kvp.Value;
                }

                foreach (var kvp in playersData[player2])
                {
                    player2Skills += kvp.Value;
                    for (int i = 0; i < player1Positions.Count; i++)
                    {
                        if (kvp.Key == player1Positions[i])
                        {
                            battle = true;
                        }
                    }
                }

                if (battle)
                {
                    if (player1Skills > player2Skills)
                    {
                        playersData.Remove(player2);
                    }
                    else if (player1Skills < player2Skills)
                    {
                        playersData.Remove(player1);
                    }
                }
            }
        }

        static void DataEntry(string[] dataInput, Dictionary<string, Dictionary<string, int>> playersData)
        {
            string player = dataInput[0];
            string position = dataInput[1];
            int skill = int.Parse(dataInput[2]);

            if (!playersData.ContainsKey(player))
            {
                playersData.Add(player, new Dictionary<string, int>());
                playersData[player].Add(position, skill);
            }
            else if (!playersData[player].ContainsKey(position))
            {
                playersData[player].Add(position, skill);
            }
            else if (playersData[player][position] < skill)
            {
                playersData[player][position] = skill;
            }
        }
    }
}