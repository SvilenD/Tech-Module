using System;
using System.Linq;

namespace RectanglePosition
{
    class Rectangle
    {
        public Rectangle(int left, int top, int width, int height)
        {
            this.Top = top;
            this.Bottom = top + height;
            this.Left = left;
            this.Right = left + width;
            this.Width = width;
            this.Height = height;
        }
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        // Method Description:
        /// <summary>
        /// Checks if first Rectangle is Inside second Rectangle.
        /// </summary>
        /// <param name="secondRectangle"></param>
        /// <returns></returns>
        public bool IsInsisde(Rectangle second)
        {
            bool leftIsInside = second.Left <= Left;
            bool topIsInside = second.Top <= Top;
            bool rightIsInside = second.Right >= Right;
            bool bottomIsInside = second.Bottom >= Bottom;

            return topIsInside && bottomIsInside && leftIsInside && rightIsInside;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var firstRect = ReadRectangle();
            var secondRect = ReadRectangle();

            bool result = firstRect.IsInsisde(secondRect);
            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
            //    var printResult = result ? "Inside" : "Not inside";
        }

        static Rectangle ReadRectangle()
        {
            var rectangleData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int left = rectangleData[0];
            int top = rectangleData[1];
            int width = rectangleData[2];
            int height = rectangleData[3];
            var rectangle = new Rectangle(left, top, width, height);

            return rectangle;
        }
    }
}