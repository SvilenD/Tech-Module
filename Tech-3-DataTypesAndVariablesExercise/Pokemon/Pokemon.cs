using System;
using System.Diagnostics;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = Stopwatch.StartNew();

            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustFactor = int.Parse(Console.ReadLine());

            double halfPower = power / 2.0;
            int targetsCount = 0;

            while (power >= distance)
            {
                power -= distance;
                targetsCount++;

                if (power == halfPower && exhaustFactor != 0)
                {
                    power /= exhaustFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targetsCount);
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}