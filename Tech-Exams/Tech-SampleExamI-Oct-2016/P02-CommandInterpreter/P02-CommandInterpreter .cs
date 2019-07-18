using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CommandInterpreter
{
    class Program
    {
        static int start = 0;
        static int count = 0;

        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "reverse":
                        start = int.Parse(input[2]);
                        count = int.Parse(input[4]);
                        ReversePartOfSequence(sequence);
                        break;
                    case "sort":
                        start = int.Parse(input[2]);
                        count = int.Parse(input[4]);
                        SortPartOfSequence(sequence);
                        break;
                    case "rollLeft":
                        count = int.Parse(input[1]);
                        RollLeftElements(sequence);
                        break;
                    case "rollRight":
                        count = int.Parse(input[1]);
                        RollRightElements(sequence);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", sequence)}]");
        }

        private static void RollRightElements(List<string> sequence)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            count = count % sequence.Count();
            for (int i = 0; i < count; i++)
            {
                sequence.Insert(0, sequence[sequence.Count - 1]);
                sequence.RemoveAt(sequence.Count - 1);
            }
        }

        private static void RollLeftElements(List<string> sequence)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            count = count % sequence.Count();
            for (int i = 0; i < count; i++)
            {
                sequence.Add(sequence[0]);
                sequence.RemoveAt(0);
            }
        }

        private static void SortPartOfSequence(List<string> sequence)
        {
            if (start < 0 || start >= sequence.Count || (start + count) > sequence.Count || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                string[] array = sequence.GetRange(start, count).ToArray();
                array = array.OrderBy(x => x).ToArray();
                int index = 0;
                for (int i = start; i < start + count; i++)
                {
                    sequence[i] = array[index];
                    index++;
                }
            }
        }

        static void ReversePartOfSequence(List<string> sequence)
        {
            if (start < 0 || start >= sequence.Count || (start + count) > sequence.Count || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                string[] array = sequence.GetRange(start, count).ToArray();
                array = array.Reverse().ToArray();
                int index = 0;
                for (int i = start; i < start + count; i++)
                {
                    sequence[i] = array[index];
                    index++;
                }
            }
        }
    }
}
