using System;

namespace P01_SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiency = 0;
            for (int i = 0; i < 3; i++)
            {
                efficiency += int.Parse(Console.ReadLine());
            }
            int students = int.Parse(Console.ReadLine());

            int hours = 0;
            while (students > 0)
            {
                hours++;
                if (hours % 4 != 0 || hours == 0)
                {
                    students -= efficiency;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
