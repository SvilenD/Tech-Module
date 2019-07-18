using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToArray();

            int lastPosition = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Merry")
                {
                    break;
                }

                int jumpLength = int.Parse(input[1]);

                lastPosition += jumpLength;

                while (lastPosition >= houses.Length)
                {
                    lastPosition -= houses.Length;
                }

                if (houses[lastPosition] > 2)
                {
                    houses[lastPosition] -= 2;
                }

                else if (houses[lastPosition] == 0)
                {
                    Console.WriteLine($"House {lastPosition} will have a Merry Christmas.");
                }
                else
                {
                    houses[lastPosition] = 0;
                }

            }
            Console.WriteLine($"Santa's last position was {lastPosition}.");
            if (houses.Max() < 1)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int[] count = houses.Where(x => x != 0).ToArray();
                Console.WriteLine($"Santa has failed {count.Count()} houses.");
            }
        }
    }
}
