using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_HornetArmada 
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var legionsData = new List<Legion>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (legionsData.Any(x => x.Name == legionName))
                {
                    int index = legionsData.FindIndex(x => x.Name == legionName);

                    if (legionsData[index].Soldiers.ContainsKey(soldierType))
                    {
                        legionsData[index].Soldiers[soldierType] += soldierCount;
                    }
                    else
                    {
                        legionsData[index].Soldiers.Add(soldierType, soldierCount);
                    }

                    if (lastActivity > legionsData[index].LastActivity)
                    {
                        legionsData[index].LastActivity = lastActivity;
                    }
                }
                else
                {
                    var legion = new Legion(lastActivity, legionName, soldierType, soldierCount);
                    legionsData.Add(legion);
                }
            }

            var filter = Console.ReadLine().Split('\\');
            if (filter.Length > 1)
            {
                int activity = int.Parse(filter[0]);
                string type = filter[1];

                var filteredSoldiers = new Dictionary<string, long>();
                foreach (var legion in legionsData.Where(x => x.LastActivity < activity))
                {
                    var soldiers = legion.Soldiers.Where(x => x.Key == type);
                    foreach (var kvp in soldiers)
                    {
                        filteredSoldiers.Add(legion.Name, kvp.Value);
                    }
                }
                foreach (var kvp in filteredSoldiers.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
            else
            {
                foreach (var legion in legionsData.OrderByDescending(x => x.LastActivity))
                {
                    if (legion.Soldiers.ContainsKey(filter[0]))
                    {
                        Console.WriteLine($"{legion.LastActivity} : {legion.Name}");
                    }
                }
            }
        }
    }

    class Legion
    {
        public Legion(int lastActivity, string legionName, string soldierType, long soldierCount)
        {
            this.LastActivity = lastActivity;
            this.Name = legionName;
            this.Soldiers = new Dictionary<string, long>();
            Soldiers.Add(soldierType, soldierCount);
        }
        public int LastActivity { get; set; }
        public string Name { get; set; }
        public Dictionary<string, long> Soldiers { get; set; }
    }
}