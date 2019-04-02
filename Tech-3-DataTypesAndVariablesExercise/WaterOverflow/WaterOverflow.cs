using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int total = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());

                if (waterQuantity + total > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }

                else
                {
                    total += waterQuantity;
                }
            }
            Console.WriteLine(total);
        }
    }
}
