using System;

namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTriangle(input);
        }

        static void PrintTriangle(int input)
        {
            PrintUpperPart(input);
            PrintMiddlePart(input);
            PrintLowerPart(input);
        }
        static void PrintUpperPart(int end)
        {
            for (int row = 1; row <= end; row++)
            {
                for (int num = 1; num < row; num++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintMiddlePart(int end)
        {
            for (int num = 1; num <= end; num++)
            {
            Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void PrintLowerPart(int end)
        {
            for (int row = end -1; row >= 1; row--)
            {
                for (int num = 1; num <= row; num++)
                {
                    Console.Write(num +" ");
                }
                Console.WriteLine();
            }
        }
    }
}