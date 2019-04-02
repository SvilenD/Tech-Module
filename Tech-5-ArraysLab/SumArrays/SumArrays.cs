using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] firstArray = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] secondArray = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] sum = SumArrays(firstArray, secondArray);

        PrintArray(sum);
    }

    static int[] SumArrays(int[] first, int[] second)
    {
        int length = Math.Max(first.Length, second.Length);

        int[] sum = new int[length];

        int index1 = 0;
        int index2 = 0;

        for (int i = 0; i < length; i++)
        {
            if (index1 >= first.Length)
            {
                index1 = 0;
            }
            if (index2 >= second.Length)
            {
                index2 = 0;
            }
            sum[i] = first[index1] + second[index2];
            index1++;
            index2++;
        }
        return sum;
    }

    static void PrintArray(int[] sum)
    {
        foreach (int item in sum)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}