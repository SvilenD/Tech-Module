using System;
using System.Linq;

class FoldAndSum
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] firstRow = GenerateFirstRow(array);
        int[] secondRow = GenerateSecondRow(array);
        int[] sumArray = SumArray(firstRow, secondRow);

        Console.WriteLine(string.Join(" ", sumArray));
    }

    static int[] GenerateFirstRow(int[] array)
    {
        int[] firstRow = new int[array.Length / 2];

        for (int i = 0; i < firstRow.Length / 2; i++)
        {
            firstRow[i] = array[firstRow.Length / 2 - 1 - i];
            firstRow[firstRow.Length - 1 - i] = array[array.Length - firstRow.Length / 2 + i];
        }

        return firstRow;
    }

    static int[] GenerateSecondRow(int[] array)
    {
        int[] secondRow = new int[array.Length / 2];

        for (int i = 0; i < secondRow.Length; i++)
        {
            secondRow[i] = array[i + secondRow.Length / 2];
        }

        return secondRow;
    }

    static int[] SumArray(int[] first, int[] second)
    {
        int[] sum = new int[first.Length];

        for (int i = 0; i < first.Length; i++)
        {
            sum[i] = first[i] + second[i];
        }

        return sum;
    }
}