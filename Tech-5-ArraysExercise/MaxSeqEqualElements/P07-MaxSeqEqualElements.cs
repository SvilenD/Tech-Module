using System;
using System.Linq;


namespace MaxSeqEqualElements
{
    class MaxSeqEqualElements
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int maxCount = 0;
            int num = 0;
            for (int i = 0; i < input.Length -1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        num = input[i];
                        maxCount = count;
                    }
                }
                else count = 1;
            }
            int[] result = new int[maxCount];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = num;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}