using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "3:1")
                {
                    break;
                }
                else if (command[0] == "merge")
                {
                    MergeItems(input, command);
                }
                else if (command[0] == "divide")
                {
                    DivideItem(input, command);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }

        private static void DivideItem(List<string> input, string[] command)
        {
            int index = int.Parse(command[1]);
            int pieces = int.Parse(command[2]);

            List<char> item = input[index].ToCharArray().ToList();
            input.RemoveAt(index);

            int endIndex = index + pieces - 1;
            for (int i = index; i < endIndex; i++)
            {
                input.Insert(i, "");
            }

            int pieceLength = item.Count / pieces;
            int lastPieceLength = item.Count % pieces + pieceLength;

            input.Insert(endIndex, string.Join("", item.TakeLast(lastPieceLength)));

            item.RemoveRange((pieces - 1) * pieceLength, lastPieceLength);

            for (int j = index; j < endIndex; j++)
            {
                input[j] = string.Join("", item.Take(pieceLength));
                item.RemoveRange(0, pieceLength);
            }
        }

        private static void MergeItems(List<string> input, string[] command)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);
            string merged = string.Empty;

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= input.Count)
            {
                endIndex = input.Count - 1;
            }
            if (startIndex >= endIndex)
            {
                return;
            }

            int count = endIndex - startIndex + 1;
            merged = string.Join("", input.GetRange(startIndex, count));
            input[startIndex] = merged;
            input.RemoveRange(startIndex + 1, count - 1);
        }
    }
}