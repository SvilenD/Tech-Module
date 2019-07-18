using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04_RoliTheCoder      //80/100
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<int, Dictionary<string, List<string>>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                //string pattern = @"^(\d+)[' ']#(\w+)[' ']@(\w+)[' ']@(\w+)$";
                //MatchCollection matches = Regex.Matches(input, pattern);
                string[] splitted = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(splitted[0]);

                string eventName = splitted[1];
                if (!eventName.Contains('#'))
                {
                    continue;
                }
                eventName = eventName.Remove(0, 1);
                var participants = new List<string>();
                for (int i = 2; i < splitted.Length; i++)
                {
                    if (splitted[i][0] != '@')
                    {
                        continue;
                    }
                    if (!participants.Contains(splitted[i]))
                    {
                        participants.Add(splitted[i]);
                    }
                }
                if (!data.ContainsKey(id))
                {
                    data.Add(id, new Dictionary<string, List<string>>());
                    data[id].Add(eventName, participants);
                    data[id][eventName].Sort();
                }
                else if (data[id].ContainsKey(eventName))
                {
                    for (int i = 0; i < participants.Count; i++)
                    {
                        if (!data[id][eventName].Contains(participants[i]))
                        {
                            data[id][eventName].Add(participants[i]);
                        }
                    }
                    data[id][eventName].Sort();
                }
            }
            foreach (var kvp in data.OrderByDescending(x => x.Value.Values.SelectMany(v => v).Count())) // ThenBy name of event...
            {
                foreach (var nKvp in kvp.Value)
                {
                    int count = data[kvp.Key][nKvp.Key].Count();
                    Console.WriteLine($"{nKvp.Key} - {count}");
                    for (int i = 0; i < nKvp.Value.Count; i++)
                    {
                        Console.WriteLine(nKvp.Value[i]);
                    }
                }
            }
        }
    }
}
