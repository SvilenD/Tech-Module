using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_IronGirder
{
    class Program
    {
        static void Main(string[] args)
        {
            var towns = new Dictionary<string, int[]>();

            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Slide rule")
                {
                    break;
                }
                else if (input[1] == "ambush")
                {
                    if (towns.ContainsKey(input[0]))
                    {
                        var name = input[0];
                        int passengers = int.Parse(input[2]);

                        var town = towns.FirstOrDefault(t => t.Key == name);
                        town.Value[0] = 0;
                        town.Value[1] -= passengers;
                    }
                }
                else
                {
                    var name = input[0];
                    var time = int.Parse(input[1]);
                    int passengers = int.Parse(input[2]);

                    if (!towns.ContainsKey(name))
                    {
                        towns.Add(name, new int[2] { time, passengers });
                    }
                    else
                    {
                        var town = towns.FirstOrDefault(t => t.Key == name);
                        if (town.Value[0] > time || town.Value[0] == 0)
                        {
                            town.Value[0] = time;
                        }
                        town.Value[1] += passengers;
                    }
                }
            }

            foreach (var town in towns.Where(t => t.Value.All(v => v != 0))
                .OrderBy(t => t.Value[0]).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{town.Key} -> Time: {town.Value[0]} -> Passengers: {town.Value[1]}");
            }
        }
    }
}