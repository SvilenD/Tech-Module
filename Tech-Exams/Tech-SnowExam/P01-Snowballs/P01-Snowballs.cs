using System;

namespace P01_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string result = string.Empty;
            double maxValue = 0;
            for (int i = 0; i < num; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                double time = double.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                double value = Math.Pow(snow / time, quality);
                if (value > maxValue)
                {
                    maxValue = value;
                    result = $"{snow} : {time} = {value} ({quality})";
                }
            }
            Console.WriteLine(result);
        }
    }
}
