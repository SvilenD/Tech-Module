using System;

namespace TempConversion
{
    class TempConversion
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celcius = Covert(fahrenheit);
            Console.WriteLine($"{celcius:f2}");
        }

        static double Covert(double fahrenheit)
        {
            double celcius = ((fahrenheit - 32) * 5 / 9);
            return celcius;
        }
    }
}