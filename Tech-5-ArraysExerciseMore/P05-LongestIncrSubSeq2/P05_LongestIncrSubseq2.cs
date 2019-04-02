using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_LongestIncrSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> longestSequence = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                List<int> sequence = new List<int>();
                sequence.Add(input[i]);
                int count = input.Count;
                for (int j = i + 1; j < count; j++)
                {
                    var subInput = input.Where(x => x > sequence[sequence.Count - 1]).ToList();

                    if (subInput.Count < 1)
                    {
                        break;
                    }
                    int minNum = subInput.Min();
                    sequence.Add(minNum);

                    int lastNumIndex = input.IndexOf(minNum);
                    for (int k = lastNumIndex; k >= 0; k--)
                    {
                        if (input.Count > 0)
                        {
                            input.RemoveAt(k);
                        }
                    }
                }
                if (sequence.Count > longestSequence.Count)
                {
                    longestSequence = sequence;
                }
            }
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}