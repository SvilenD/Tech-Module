using System;

namespace P06_CalculateRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(side, height));
        }

        static double TriangleArea(double a, double h)
        {
            double area = a * h;
            return area;
        }
    }
}