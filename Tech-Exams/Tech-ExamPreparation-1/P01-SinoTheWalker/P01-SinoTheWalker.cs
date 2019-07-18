using System;
using System.Numerics;

namespace P01_SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeOfLeaving = DateTime.Parse(Console.ReadLine());
            uint stepsTaken = uint.Parse(Console.ReadLine()) % 86400;
            uint stepsPerSec = uint.Parse(Console.ReadLine()) % 86400;

            //int step = int.Parse(Console.ReadLine()) % 86400;
            //int seconds = int.Parse(Console.ReadLine()) % 86400;
            //86400 секунди = 1 ден
            //махаме цели дни, ако някой се прави на интересен да ни ги подава като вход

            double addedSeconds = stepsTaken * stepsPerSec;
            DateTime arrivalTime = timeOfLeaving.AddSeconds(addedSeconds);
            Console.WriteLine($"Time Arrival: {arrivalTime.Hour:d2}:{arrivalTime.Minute:d2}:{arrivalTime.Second:d2}");
            // Console.WriteLine("Time Arrival: {0:HH:mm:ss}", arrivalTime);
        }
    }
}