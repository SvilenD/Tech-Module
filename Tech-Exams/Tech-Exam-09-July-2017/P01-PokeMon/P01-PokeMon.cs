using System;

namespace P01_PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int power = initialPower;
            int targetCount = 0;
            while (power >= distance)
            {
                power -= distance;
                targetCount++;
                if (power == 0.5*initialPower && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targetCount);
        }
    }
}
