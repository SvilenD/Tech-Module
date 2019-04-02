using System;

namespace P07_NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            PrintMatrix(matrixSize);
        }

        static void PrintMatrix(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(size +" ");
                }
                Console.WriteLine();
            }

        }
    }
}
