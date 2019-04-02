using System;

namespace CenterPoint
{
    class CenterPoint
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintCloserToCenterPoint(x1, y1, x2, y2);
        }

        static void PrintCloserToCenterPoint(double x1, double y1, double x2, double y2)
        {
            double distance1 = CalculatePitagorean(x1, y1);
            double distance2 = CalculatePitagorean(x2, y2);

            if (distance1 <= distance2)
            {
                PrintResult(x1, y1);
            }
            else 
            {
                PrintResult(x2, y2);
            }
        }

        static double CalculatePitagorean(double x, double y)
        {
            double result = Math.Sqrt((Math.Pow(x, 2)) + Math.Pow(y, 2));
            return result;
        }

        static void PrintResult(double x, double y)
        {
            Console.WriteLine($"({x}, {y})");
        }
    }
}