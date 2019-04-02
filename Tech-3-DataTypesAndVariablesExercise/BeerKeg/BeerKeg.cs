using System;

namespace BeerKeg
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double maxVolume = 0;
            string biggest = string.Empty;
            for (int i = 0; i < count; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentVolume  = Math.PI * radius * radius * height;
                if (currentVolume > maxVolume)
                {
                    biggest = model;
                    maxVolume = currentVolume;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}