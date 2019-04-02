using System;
using System.Linq;

namespace P02_GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int count = sequence.Count / 2;

            for (int i = 0; i < count; i++)
            {
                sequence[i] += sequence[sequence.Count - 1];
                sequence.RemoveAt(sequence.Count - 1);
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}