using System;
using System.Collections.Generic;
using System.Linq;

namespace M05_DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> drumsInUse = drums.ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hitPower = int.Parse(input);
                drumsInUse = drumsInUse.Where(x => x > 0).Select(x => x - hitPower).ToList();

                while (drumsInUse.Any(x => x <= 0))
                {
                    int brokenDrumIndex = drumsInUse.FindIndex(x => x <= 0);
                    double price = drums[brokenDrumIndex] * 3;
                    if (savings >= price)
                    {
                        drumsInUse[brokenDrumIndex] = drums[brokenDrumIndex];
                        savings -= price;
                    }
                    else
                    {
                        drumsInUse.RemoveAt(brokenDrumIndex);
                        drums.RemoveAt(brokenDrumIndex);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", drumsInUse));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
