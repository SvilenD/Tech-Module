using System;
using System.Linq;

namespace P02_KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var bestDNA = new int[length];
            int index = 0;
            int bestIndex = 1;
            int bestCount = 0;
            int start = 0;
            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Clone them")
                {
                    break;
                }
                index++;
                var DNA = input.Select(int.Parse).ToArray();
                int count = 0;
                for (int i = 0; i < DNA.Length; i++)
                {
                    bool best = false;
                    if (DNA[i] == 1)
                    {
                        count++;
                        if (count > bestCount)
                        {
                            best = true;
                        }
                        else if (count == bestCount)
                        {
                            if (start > i - count)
                            {
                                best = true;
                            }
                            else if (start == i - count && bestDNA.Sum() < DNA.Sum())
                            {
                                best = true;
                            }
                        }
                    }
                    else
                    {
                        count = 0;
                    }

                    if (best)
                    {
                        bestDNA = input.Select(int.Parse).ToArray();
                        bestCount = count;
                        bestIndex = index;
                        start = i - count;
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestDNA.Sum()}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
