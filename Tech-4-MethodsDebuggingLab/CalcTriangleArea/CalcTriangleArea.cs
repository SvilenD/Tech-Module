using System;

namespace CalcTriangleArea
{
    class CalcTriangleArea
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(TriangleArea(side, height));
        }

        static double TriangleArea(double a, double h)
        {
            double area = a * h / 2.0;
            return area;
        }
    }
}