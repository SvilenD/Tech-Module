using System;
using System.Linq;

namespace P03_EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var driversNames = Console.ReadLine().Split();
            var trackZones = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkpointIndexes = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < driversNames.Length; i++)
            {
                string driver = driversNames[i];

                double fuel = driver[0];

                for (int zone = 0; zone < trackZones.Length; zone++)
                {
                    if (checkpointIndexes.Contains(zone))
                    {
                        fuel += trackZones[zone];
                    }
                    else
                    {
                        fuel -= trackZones[zone];
                    }
                    if (fuel < 1)
                    {
                        Console.WriteLine($"{driver} - reached {zone}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
