using System;
using System.Collections.Generic;
using System.Linq;

namespace P02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('#');
            int water = int.Parse(Console.ReadLine());

            double effort = 0;
            var putOutFires = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                bool valid = false;
                var fire = input[i].Split(" = ");
                var type = fire[0];
                int waterNeeded = int.Parse(fire[1]);
                if (type == "High" && waterNeeded >= 81 && waterNeeded <= 125)
                {
                    valid = true;
                }
                else if (type == "Medium" && waterNeeded >= 51 && waterNeeded <= 80)
                {
                    valid = true;
                }
                else if (type == "Low" && waterNeeded >= 1 && waterNeeded <= 50)
                {
                    valid = true;
                }
                if (valid && water >= waterNeeded)
                {
                    water -= waterNeeded;
                    putOutFires.Add(waterNeeded);
                    effort += waterNeeded * 0.25;
                }
            }
            Console.WriteLine("Cells:");
            for (int i = 0; i < putOutFires.Count; i++)
            {
                Console.WriteLine($" - {putOutFires[i]}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {putOutFires.Sum()}");
        }
    }
}