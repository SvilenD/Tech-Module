using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float metersDist = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalSeconds = seconds + minutes * 60 + hours * 60 * 60;
            float meterPerSec = metersDist / totalSeconds;
            float kmPerHour = (metersDist / 1000f) / (totalSeconds / 3600f); 
            float mph = (metersDist / 1609f) / (totalSeconds / 3600f);
            Console.WriteLine(meterPerSec);
            Console.WriteLine(kmPerHour);
            Console.WriteLine(mph);
        }
    }
}
