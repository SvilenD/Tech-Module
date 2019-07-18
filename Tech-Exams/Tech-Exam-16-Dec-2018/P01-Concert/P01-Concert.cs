using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Concert
{
    class Program
    {
        static Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
        static Dictionary<string, long> bandsTime = new Dictionary<string, long>();

        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine().Split("; ");

                if (input[0] == "start of concert")
                {
                    break;
                }
                else if (input[0] == "Add")
                {
                    AddBand(input);
                }
                else if (input[0] == "Play")
                {
                    AddPlayTime(input);
                }
            }

            Console.WriteLine($"Total time: {bandsTime.Sum(x => x.Value)}");
            foreach (var band in bandsTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }
            var printMembers = Console.ReadLine();
            foreach (var band in bands.Where(x => x.Key == printMembers))
            {
                Console.WriteLine(printMembers);
                for (int i = 0; i < band.Value.Count; i++)
                {
                    Console.WriteLine($"=> {band.Value[i]}");
                }
            }
        }

        static void AddPlayTime(string[] input)
        {
            var name = input[1];
            int time = int.Parse(input[2]);
            if (!bandsTime.ContainsKey(name))
            {
                bandsTime.Add(name, time);
            }
            else
            {
                bandsTime[name] += time;
            }
        }

        static void AddBand(string[] input)
        {
            var name = input[1];
            var members = input[2].Split(", ").ToList();
            if (!bands.ContainsKey(name))
            {
                bands.Add(name, members);
            }
            else
            {
                for (int i = 0; i < members.Count; i++)
                {
                    if (!bands[name].Contains(members[i]))
                    {
                        bands[name].Add(members[i]);
                    }
                }
            }
        }
    }
}