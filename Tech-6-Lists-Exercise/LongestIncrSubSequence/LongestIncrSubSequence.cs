using System;
using System.Collections.Generic;
using System.Linq;


namespace LongestIncrSubSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> maxIncrSequence = new List<int>();
            for (int index = 0; index < input.Count; index++)
            {
                List<int> incrList = new List<int>();
                incrList.Add(input[index]);
                
                for (int j = index + 1; j < input.Count; j++)
                {
                    if (incrList.Last() < input[j])
                    {
                        incrList.Add(input[j]);
                    }
                    if (incrList.Count > maxIncrSequence.Count)
                    {
                        maxIncrSequence = incrList;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', maxIncrSequence));
        }
    }
}
