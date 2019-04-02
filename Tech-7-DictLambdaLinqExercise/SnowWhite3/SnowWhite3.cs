using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite3
{
    class Dwarf
    {
        public Dwarf(string name, string hatColor, long physics)
        {
            this.Name = name;
            this.HatColor = hatColor;
            this.Physics = physics;
        }
        public string Name { get; set; }
        public string HatColor { get; set; }
        public long Physics { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfsList = new List<Dwarf>();
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Once upon a time")
                {
                    break;
                }
                var name = input[0].Trim();
                var hatColor = input[1].Trim();
                var physics = long.Parse(input[2]);

                var newDwarf = new Dwarf(name, hatColor, physics);
                if (!dwarfsList.Any(x => x.Name == name))
                {
                    dwarfsList.Add(newDwarf);
                }
                else 
                {
                    int index = dwarfsList.FindIndex(x => x.Name == name);
                    if (dwarfsList[index].HatColor != hatColor)
                    {
                        dwarfsList.Add(newDwarf);
                    }
                    else if (dwarfsList[index].Physics < physics)
                    {
                        dwarfsList[index].Physics = physics;
                    }
                }
            }
            dwarfsList = dwarfsList.OrderByDescending(x => x.Physics).ThenByDescending(y => y.HatColor.Count()).ToList();
            foreach (var dwarf in dwarfsList)
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
