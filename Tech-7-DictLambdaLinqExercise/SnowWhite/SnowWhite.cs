using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfData = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }
                string[] data = input.Split(" <:> ").ToArray();

                dwarfData = DataEntry(data, dwarfData);
            }

            foreach (var kvp in dwarfData.OrderByDescending(x => x.Value))
            {
                string[] nameColour = kvp.Key.Split('/').ToArray();

                string name = nameColour[0];
                string hatColor = nameColour[1];
                int physics = kvp.Value;

                Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            }
        }

        private static Dictionary<string, int> DataEntry(string[] data, Dictionary<string, int> dwarfData)
        {
            string nameColour = data[0] + '/' + data[1];
            int physics = int.Parse(data[2]);

            if (!dwarfData.ContainsKey(nameColour))
            {
                dwarfData.Add(nameColour, physics);
            }

            else if (physics > dwarfData[nameColour])
            {
                dwarfData[nameColour] = physics;
            }
            return dwarfData;
        }
    }
}