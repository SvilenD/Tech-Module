using System;
using System.Linq;

namespace P03_TargetMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int rowsNum = dimensions[0];
            int colsNum = dimensions[1];

            int[,] matrix = new int[rowsNum, colsNum];
            for (int row = 0; row < rowsNum; row++)
            {
                int[] col = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int index = 0; index < col.Length; index++)
                {
                    matrix[row, index] = col[index];
                }
            }
            int[] target = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int targetRow = target[0];
            int targetCol = target[1];

            int sumNeighbors = 0;
            int targetValue = matrix[targetRow, targetCol];
            for (int row = targetRow - 1; row <= targetRow + 1; row++)
            {
                for (int col = targetCol- 1; col <= targetCol + 1; col++)
                {
                    if (row == targetRow && col == targetCol)
                    {
                        continue;
                    }
                        sumNeighbors += matrix[row, col];
                        matrix[row, col] *= targetValue;
                }
            }
            matrix[targetRow, targetCol] *= sumNeighbors;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
