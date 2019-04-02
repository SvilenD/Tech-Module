using System;

class GeometryCalculator
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine().ToLower();
        ReadParameters(figure);
    }

    static void ReadParameters(string figure)
    {
        switch (figure)
        {
            case "triangle": CalculateTriangleArea(figure); break;
            case "square": CalculateSquareArea(figure); break;
            case "rectangle": CalculateRectangleArea(figure); break;
            case "circle": CalculateCircleArea(figure); break;
        }
    }

    static void CalculateTriangleArea(string triangle)
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = side * height / 2.0;
        PrintResult(area);
    }

    static void CalculateSquareArea(string square)
    {
        double side = double.Parse(Console.ReadLine());
        double area = side * side;
        PrintResult(area);
    }

    static void CalculateRectangleArea(string rectangle)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        PrintResult(area);
    }

    static void CalculateCircleArea(string circle)
    {
        double radius = double.Parse(Console.ReadLine());
        double area =  Math.PI * radius * radius;
        PrintResult(area);
    }

    static void PrintResult(double area)
    {
        Console.WriteLine($"{area:f2}");
    }
}