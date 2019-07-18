using System;

namespace P01_HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int flapsNum = int.Parse(Console.ReadLine()); // 100 flaps per second.
            double distFor1000flaps = double.Parse(Console.ReadLine()); // meters.
            int endurance = int.Parse(Console.ReadLine()); // wing flaps he can make, before he stops to take a rest for 5 seconds.

            double distance = flapsNum * distFor1000flaps / 1000;

            int seconds = flapsNum / 100 + flapsNum / endurance*5;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}