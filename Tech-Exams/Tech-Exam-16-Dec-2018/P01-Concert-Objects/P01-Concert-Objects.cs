using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Concert_Objects
{
    class Band
    {
        public Band(string name, List<string> members, int time)
        {
            this.Name = name;
            this.Members = members;
            this.Time = time;
        }

        public string Name { get; set; }

        public List<string> Members { get; set; }

        public int Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bandsList = new List<Band>();

            while (true)
            {
                var input = Console.ReadLine().Split("; ");
                if (input[0] == "start of concert")
                {
                    break;
                }

                var command = input[0];
                var name = input[1];
                int time = 0;
                if (command == "Add")
                {
                    var members = input[2].Split(", ").ToList();
                    if (bandsList.Any(x => x.Name == name) == false)
                    {
                        var band = new Band(name, members, time);
                        bandsList.Add(band);
                    }
                    else
                    {
                        var currentBand = bandsList.FirstOrDefault(b => b.Name.Equals(name));
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (currentBand.Members.Contains(members[i]) == false)
                            {
                                currentBand.Members.Add(members[i]);
                            }
                        }
                    }
                }
                else if (command == "Play")
                {
                    time = int.Parse(input[2]);
                    if (bandsList.Any(x => x.Name == name) == false)
                    {
                        var members = new List<string>();
                        var band = new Band(name, members, time);
                        bandsList.Add(band);
                    }
                    else
                    {
                        var currentBand = bandsList.FirstOrDefault(b => b.Name == name);
                        currentBand.Time += time;
                    }
                }
            }

            long totalTime = bandsList.Sum(b => b.Time);
            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandsList.OrderByDescending(b=>b.Time).ThenBy(b=>b.Name))
            {
                Console.WriteLine($"{band.Name} -> {band.Time}");
            }

            var bandName = Console.ReadLine();
            Console.WriteLine(bandName);
            var selectedBand = bandsList.FirstOrDefault(b => b.Name == bandName);
            for (int i = 0; i < selectedBand.Members.Count; i++)
            {
                Console.WriteLine($"=> {selectedBand.Members[i]}");
            }
        }
    }
}