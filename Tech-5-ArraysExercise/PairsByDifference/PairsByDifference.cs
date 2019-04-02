using System;
using System.Linq;

namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numSequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < numSequence.Length; i++)
            {
                for (int j = 0; j < numSequence.Length; j++)
                {
                    if (numSequence[i] + difference == numSequence[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
