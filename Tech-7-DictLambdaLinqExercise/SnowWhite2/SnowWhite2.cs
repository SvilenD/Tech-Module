using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite2
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
            var dwarvesList = new List<Dwarf>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }
                string[] data = input.Split(new[] { ' ', '<', '>', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                AddData(data, dwarvesList);
            }

            foreach (Dwarf dwarf in dwarvesList.OrderByDescending(x => x.Physics)   //.ThenBy(z => z.HatColor).ThenByDescending(y => y.HatColor.Count())) 70/100
                .ThenByDescending(x => dwarvesList.Count(y => y.HatColor == x.HatColor))) //copy-paste of foruma

            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        static void AddData(string[] data, List<Dwarf> dwarvesList)
        {
            string name = data[0];
            string hatColor = data[1];
            int physics = int.Parse(data[2]);

            var dwarf = new Dwarf(name, hatColor, physics);
            if (!dwarvesList.Any(x => x.Name == name))
            {
                dwarvesList.Add(dwarf);
            }
            else if (dwarvesList.Any(x => x.Name == name))
            {
                int index = dwarvesList.FindIndex(x => x.Name == name);
                if (dwarvesList[index].HatColor != hatColor)
                {
                    dwarvesList.Add(dwarf);
                }
                else if (dwarvesList[index].Physics <= physics)
                {
                    dwarvesList[index].Physics = physics;
                }
            }
        }
    }
}