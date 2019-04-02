using System;
using System.Linq;

namespace EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool equalSums = false;

            for (int i = 0; i < input.Length; i++)
            {
                rightSum += input[i];
            }

            for (int index = 0; index < input.Length; index++)
            {
                leftSum += input[index];
                if (leftSum == rightSum)
                {
                    Console.WriteLine(index);
                    equalSums = true;
                }
                rightSum -= input[index];
            }

            if (!equalSums) Console.WriteLine("no");
        }
    }
}