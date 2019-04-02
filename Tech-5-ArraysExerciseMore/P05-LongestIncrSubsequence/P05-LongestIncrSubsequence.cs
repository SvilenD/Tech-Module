using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_LongestIncrSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> longestSequence = new List<int>();
            var numbersLeft = new List<int>();
            for (int i = 0; i < input.Length - 1; i++)
            {
                List<int> sequence = new List<int>();
                sequence.Add(input[i]);
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j] > sequence[sequence.Count - 1])
                    {
                        sequence.Add(input[j]);
                    }

                    for (int k = 0; k < numbersLeft.Count; k++)
                    {
                        var difference = sequence.Except(numbersLeft).ToList();
                        int number = numbersLeft.FirstOrDefault(x => x < sequence[0]);
                        if (number != 0 && !sequence.Contains(number))
                        {
                            sequence.Insert(k, number);
                        }
                    }
                }
                numbersLeft.Add(input[i]);
                if (sequence.Count > longestSequence.Count)
                {
                    longestSequence = sequence;
                }
            }
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}

