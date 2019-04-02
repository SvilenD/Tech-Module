using System;

class Program
{
    static void Main(string[] args)
    {
        double cubeSide = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();

        PrintOutput(parameter, cubeSide);
    }
    static void PrintOutput(string parameter, double cubeSide)
    {
        double result = 0;
        switch (parameter)
        {
            case "face": result = CalculateCubeFace(cubeSide); break;
            case "space": result = CalculateCubeSpace(cubeSide); break;
            case "volume": result = CalculateCubeVolume(cubeSide); break;
            case "area": result = CalculateCubeArea(cubeSide); break;
        }
        Console.WriteLine(result);

    }

    private static double CalculateCubeArea(double cubeSide)
    {
        double result = Math.Round(6 * cubeSide * cubeSide, 2);
        return result;
    }

    private static double CalculateCubeSpace(double cubeSide)
    {
        double result = Math.Round(Math.Sqrt(3*cubeSide * cubeSide), 2);
        return result;
    }

    private static double CalculateCubeFace(double cubeSide)
    {
        double result = Math.Round(Math.Sqrt(2* cubeSide * cubeSide), 2);
        return result;
    }
    static double CalculateCubeVolume(double cubeSide)
    {
        double result = Math.Round(Math.Pow(cubeSide, 3), 2);
        return result; 
    }
}