using System;

namespace P01_CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int averageNumLaps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            if (runners > trackCapacity * days)
            {
                runners = trackCapacity * days;
            }
            decimal money = moneyPerKm * averageNumLaps * trackLength * runners / 1000m;
            Console.WriteLine($"Money raised: {money:f2}");
        }
    }
}
