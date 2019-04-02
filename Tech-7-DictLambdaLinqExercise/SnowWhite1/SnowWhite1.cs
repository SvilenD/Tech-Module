using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfData = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }
                string[] data = input.Split(" <:> ").ToArray();

                DataEntry(data, dwarfData);
            }

            foreach (var kvp in dwarfData.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x=>x.Value.Keys.Count)) // .ThenByDescending(x=>x.Value.Keys.Count) никаква работа не върши, как да го накарам да преброй кой цвят са най-много?!
            {
                foreach (var nKvp in dwarfData[kvp.Key])
                {
                    List<char> dwarfName = kvp.Key.ToList();
                    dwarfName.RemoveAll(x => x < 58);
                    string name = string.Join("", dwarfName.ToArray());
                    string hatColor = nKvp.Key;
                    int physics = nKvp.Value;
                    Console.WriteLine($"({hatColor}) {name} <-> {physics}");
                }
            }
        }

        static void DataEntry(string[] data, Dictionary<string, Dictionary<string, int>> dwarfData)
        {
            string name = data[0];
            string hatColour = data[1];
            int physics = int.Parse(data[2]);
            int index = 1;

            if (!dwarfData.ContainsKey(name))
            {
                dwarfData.Add(name, new Dictionary<string, int>());
                dwarfData[name].Add(hatColour, physics);
            }
            else if (!dwarfData[name].ContainsKey(hatColour))
            {
                name = name + index;
                dwarfData.Add(name, new Dictionary<string, int>());
                dwarfData[name].Add(hatColour, physics);
            }
            else if (physics > dwarfData[name][hatColour])
            {
                dwarfData[name][hatColour] = physics;
            }
        }
    }
}