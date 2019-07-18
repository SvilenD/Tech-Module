using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_HornetArmada2
{
    class Program
    {
        static void Main(string[] args)
        {
            var legionActivity = new Dictionary<string, int>();
            var legionSoldiers = new Dictionary<string, Dictionary<string, long>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(input[0]);
                var name = input[1];
                var soldierType = input[2];
                int count = int.Parse(input[3]);

                if (!legionSoldiers.ContainsKey(name))
                {
                    legionSoldiers.Add(name, new Dictionary<string, long>());
                    legionSoldiers[name].Add(soldierType, count);
                    legionActivity.Add(name, lastActivity);
                }
                else if (!legionSoldiers[name].ContainsKey(soldierType))
                {
                    legionSoldiers[name].Add(soldierType, count);
                }
                else
                {
                    legionSoldiers[name][soldierType] += count;
                }
                if (legionActivity[name] < lastActivity)
                {
                    legionActivity[name] = lastActivity;
                }
            }


            var filter = Console.ReadLine().Split('\\');
            if (filter.Length > 1)
            {
                int activity = int.Parse(filter[0]);
                string soldierType = filter[1];

                foreach (var legion in legionSoldiers.Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType]))
                {
                    if (legionActivity[legion.Key] < activity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[soldierType]}");
                    }
                }
            }
            else
            {
                string soldierType = filter[0];
                foreach (var legion in legionActivity.OrderByDescending(x => x.Value))
                {
                    if (legionSoldiers[legion.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
        }
    }
}
