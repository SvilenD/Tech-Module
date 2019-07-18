using System;
using System.Linq;

namespace P03_HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            var hornets = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                long power = hornets.Sum();     // int прелива, затова всичко long;
                if (beehives[i] < power)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= power;
                    hornets.RemoveAt(0);
                    if (hornets.Count < 1)
                    {
                        break;
                    }
                }
            }
            if (beehives.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
