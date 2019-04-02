using System;
using System.Linq;

namespace MaxSeqOfIncrElem
{
    class MaxSeqOfIncrElem
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            int increasing = 1;
            int maxIncreasing = 1;
            int end = 0;
            for (int index = 0; index < input.Length - 1; index++)
            {
                if (input[index] < input[index + 1])
                {
                    increasing++;
                    if (increasing > maxIncreasing)
                    {
                        maxIncreasing = increasing;
                        end = index + 1;
                    }
                }
                else increasing = 1;
            }
            long[] incrSequence = new long[maxIncreasing];

            for (int i = maxIncreasing -1; i >= 0; i--)
            {
                incrSequence[i] = input[end];
                end--;
            }
            foreach (int item in incrSequence)
            {
                Console.Write(item + " ");
            }
        }
    }
}