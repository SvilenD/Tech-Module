using System;
using System.Linq;

namespace ClosestTwoPoints
{
    class Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static double minDistance = double.MaxValue;

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var array = new Point[count];

            for (int i = 0; i < count; i++)
            {
                int[] coordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var point = new Point(coordinates[0], coordinates[1]);
                array[i] = point;
            }

            var closest = FindClosestPoints(array);

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({closest[0].X}, {closest[0].Y})");
            Console.WriteLine($"({closest[1].X}, {closest[1].Y})");
        }

        static Point[] FindClosestPoints(Point[] array)
        {
            var closest = new Point[2];
            for (int i = 0; i < array.Length; i++)
            {
                var first = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    var second = array[j];
                    double distance = CalculateDistance(first, second);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closest[0] = array[i];
                        closest[1] = array[j];
                    }
                }
            }
            return closest;
        }

        static double CalculateDistance(Point first, Point second)
        {
            int a = Math.Abs(first.X - second.X);
            int b = Math.Abs(first.Y - second.Y);

            double distance = Math.Sqrt(a * a + b * b);

            return distance;
        }
    }
}