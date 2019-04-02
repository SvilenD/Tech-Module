using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string key = string.Empty;
            bool legendaryItem = false;

            while (!legendaryItem)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    string item = input[i + 1];
                    int quantity = int.Parse(input[i]);

                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        materials[item] += quantity;

                        if (materials[item] >= 250)
                        {
                            materials[item] -= 250;
                            switch (item)
                            {
                                case "shards": key = "Shadowmourne"; break;
                                case "fragments": key = "Valanyr"; break;
                                case "motes": key = "Dragonwrath"; break;
                            }
                            legendaryItem = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, 0);
                        }
                        junk[item] += quantity;
                    }
                }
            }

            Console.WriteLine($"{key} obtained!");

            var resultMaterials = materials.OrderByDescending(x => x.Value).ThenBy(y => y.Key);
            var resultJunk = junk.OrderBy(x => x.Key);

            foreach (var kvp in resultMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in resultJunk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}