using System;

class LongerLine
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
    }

    static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double firstLine = CalculatePitagorean(x2 - x1, y2 - y1);
        double secondLine = CalculatePitagorean(x4 - x3, y4 - y3);

        if (firstLine >= secondLine)
        {
            bool isFirstCloser = GetCloserToCenter(x1, y1, x2, y2);
            if (isFirstCloser)
            {
                PrintResult(x1, y1, x2, y2);
            }
            else
            {
                PrintResult(x2, y2, x1, y1);
            }
        }
        else if (firstLine < secondLine)
        {
            bool isFirstCloser = GetCloserToCenter(x3, y3, x4, y4);
            if (isFirstCloser)
            {
                PrintResult(x3, y3, x4, y4);
            }
            else
            {
                PrintResult(x4, y4, x3, y3);
            }
        }
    }

    static bool GetCloserToCenter(double x1, double y1, double x2, double y2)
    {
        bool firstIsCloser = true;
        double distance1 = CalculatePitagorean(x1, y1);
        double distance2 = CalculatePitagorean(x2, y2);

        if (distance1 > distance2)
        {
            firstIsCloser = false;
        }

        return firstIsCloser;
    }

    static double CalculatePitagorean(double x, double y)
    {
        double result = Math.Sqrt((Math.Pow(x, 2)) + Math.Pow(y, 2));
        return result;
    }

    static void PrintResult(double x1, double y1, double x2, double y2)
    {
        Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
    }
}