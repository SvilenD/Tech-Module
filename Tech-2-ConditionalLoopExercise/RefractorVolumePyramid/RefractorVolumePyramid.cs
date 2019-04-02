using System;

namespace RefractorVolumePyramid
{
    class RefractorVolumePyramid
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = (length * width) * height / 3.0;
            Console.WriteLine("Length: Width: Height: Pyramid Volume: {0:F2}", volume);
        }
    }
}