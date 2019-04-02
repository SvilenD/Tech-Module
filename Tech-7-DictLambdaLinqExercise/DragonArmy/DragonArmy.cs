using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int[]>> dragonData = new Dictionary<string, Dictionary<string, int[]>>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                DataInput(input, dragonData);
            }

            PrintResult(dragonData);
        }

        static void DataInput(string[] input, Dictionary<string, Dictionary<string, int[]>> dragonData)
        {
            string color = input[0];
            string name = input[1];
            int damage = 0;
            int health = 0;
            int armor = 0;
            if (int.TryParse(input[2], out damage))
            {
            }
            else
            {
                damage = 45;
            }
            if (int.TryParse(input[3], out health))
            {
            }
            else
            {
                health = 250;
            }
            if (int.TryParse(input[4], out armor))
            {
            }
            else
            {
                armor = 10;
            }
            if (!dragonData.ContainsKey(color))
            {
                dragonData.Add(color, new Dictionary<string, int[]>());
                dragonData[color].Add(name, new int[] { damage, health, armor });
            }
            else if (dragonData[color].ContainsKey(name))
            {
                dragonData[color][name][0] = damage;
                dragonData[color][name][1] = health;
                dragonData[color][name][2] = armor;
            }
            else
            {
                dragonData[color].Add(name, new int[] { damage, health, armor });
            }
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int[]>> dragonData)
        {
            foreach (var kvp in dragonData)
            {
                string color = kvp.Key;
                double avDamage = 0;
                double avHealth = 0;
                double avArmor = 0;
                int count = 0;
                foreach (var nKvp in dragonData[color])
                {
                    avDamage += dragonData[color][nKvp.Key][0];
                    avHealth += dragonData[color][nKvp.Key][1];
                    avArmor += dragonData[color][nKvp.Key][2];
                    count++;
                }
                avDamage = avDamage / count;
                avHealth = avHealth / count;
                avArmor = avArmor / count;

                Console.WriteLine($"{color}::({avDamage:F2}/{avHealth:F2}/{avArmor:F2})");

                foreach (var nKvp in dragonData[color].OrderBy(x => x.Key))
                {
                    string name = nKvp.Key;
                    int damage = dragonData[color][name][0];
                    int health = dragonData[color][name][1];
                    int armor = dragonData[color][name][2];

                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}