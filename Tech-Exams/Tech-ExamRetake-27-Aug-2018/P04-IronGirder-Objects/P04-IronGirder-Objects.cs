using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04_IronGirder
{
    public class Town
    {
        public string Name { get; set; }

        public int Time { get; set; }

        public int Passangers { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<name>[^:>]+):(?<time>\d+)\->(?<pass>\d+)$";
            var ambushPattern = @"^(?<name>[^:>]+):(ambush)->(?<pass>\d+)$";

            var townsList = new List<Town>();
            while (true)
            {

                var input = Console.ReadLine();
                if (input == "Slide rule")
                {
                    break;
                }
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    var name = match.Groups["name"].Value;
                    int time = int.Parse(match.Groups["time"].Value);
                    int passangers = int.Parse(match.Groups["pass"].Value);

                    if (townsList.Any(x => x.Name == name))
                    {
                        foreach (var town in townsList.Where(x => x.Name == name))
                        {
                            if (town.Time > time || town.Time == 0)
                            {
                                town.Time = time;
                            }
                            town.Passangers += passangers;
                        }
                    }
                    else
                    {
                        var newTown = new Town()
                        {
                            Name = name,
                            Time = time,
                            Passangers = passangers
                        };
                        townsList.Add(newTown);
                    }
                }
                else if (input.Contains("ambush"))
                {
                    Match ambushMatch = Regex.Match(input, ambushPattern);
                    var name = ambushMatch.Groups["name"].Value;
                    int passengersAmbushed = int.Parse(ambushMatch.Groups["pass"].Value);

                    foreach (var town in townsList.Where(x => x.Name == name))
                    {
                        town.Time = 0;
                        town.Passangers -= passengersAmbushed;
                    }
                }
            }

            townsList = townsList.Where(x => x.Time > 0).Where(x => x.Passangers > 0).ToList();
            foreach (var town in townsList.OrderBy(t => t.Time).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{town.Name} -> Time: {town.Time} -> Passengers: {town.Passangers}");
            }
        }
    }
}