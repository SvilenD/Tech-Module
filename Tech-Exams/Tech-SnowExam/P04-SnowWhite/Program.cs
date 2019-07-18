using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_SnowWhite
{
    class Dwarf
    {
        public Dwarf(string name, string hatColor, int physics)
        {
            this.Name = name;
            this.HatColor = hatColor;
            this.Physics = physics;
        }

        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dwarfList = new List<Dwarf>();

            while (true)
            {
                var input = Console.ReadLine().Split(" <:> ");
                if (input[0] == "Once upon a time")
                {
                    break;
                }

                var name = input[0];
                var hatColor = input[1];
                int physics = int.Parse(input[2]);

                var dwarf = new Dwarf(name, hatColor, physics);

                if (!dwarfList.Any(x => x.Name == name))
                {
                    dwarfList.Add(dwarf);
                }

                else
                {
                    int index = dwarfList.FindIndex(x => x.Name == name);
                    if (dwarfList[index].HatColor != hatColor)
                    {
                        dwarfList.Add(dwarf);
                    }
                    else if (dwarfList[index].Physics < physics)
                    {
                        dwarfList[index].Physics = physics;
                    }
                }
            }

            foreach (var dwarf in dwarfList.OrderByDescending(x=>x.Physics).ThenByDescending(x=>dwarfList.Count(y=>y.HatColor ==x.HatColor)))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
