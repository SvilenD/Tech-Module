using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] firstArray = new int[numberOfLines];
            int[] secondArray = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();  

                if (i % 2 == 0)
                {
                    firstArray[i] = input[0];
                    secondArray[i] = input[1];
                }
                else
                {
                    firstArray[i] = input[1];
                    secondArray[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
