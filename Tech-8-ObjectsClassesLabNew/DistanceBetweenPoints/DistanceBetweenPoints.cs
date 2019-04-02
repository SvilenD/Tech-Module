using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();


            var firstPoint = new Point
            {
                X = first[0],
                Y = first[1]
            };
            var secondPoint = new Point
            {
                X = second[0],
                Y = second[1]
            };

            double distance = CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:f3}");
        }

        static double CalculateDistance(Point first, Point second)
        {
            int a = Math.Abs(first.X - second.X);
            int b = Math.Abs(first.Y - second.Y);
            double distance = Math.Sqrt(a*a + b * b);

            return distance;
        }
    }
}
