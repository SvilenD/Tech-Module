using System;

namespace BackIn30Min
{
    class BackIn30Min
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
                if (hours >= 24)
                {
                    hours -= 24;
                }
            }
            Console.WriteLine($"{ hours}:{minutes:d2}");
        }
    }
}
