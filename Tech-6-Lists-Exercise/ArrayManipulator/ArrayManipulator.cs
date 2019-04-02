using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator //  ако командата се чете като List вместо стринг дава 91/100 time limit, memory limit?! и на .netCorе и на C# code
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "add": AddToList(inputList, command); break;
                    case "addMany": AddMultipleIntsToList(inputList, command); break;
                    case "contains": FindIndex(inputList, command); break;
                    case "remove": RemoveIntAtIndex(inputList, command); break;
                    case "shift": ShiftIntsLeft(inputList, command); break;
                    case "sumPairs": SumPairsOfInts(inputList, command); break;
                    case "print": Console.WriteLine($"[{string.Join(", ", inputList)}]"); return;
                    default:
                        break;
                }
            }
        }

        static void SumPairsOfInts(List<int> inputList, string[] command)
        {
            for (ushort index = 0; index < inputList.Count - 1; index++)
            {
                int sum = inputList[index] + inputList[index + 1];
                inputList.RemoveRange(index, 2);
                inputList.Insert(index, sum);
            }
        }

        static void ShiftIntsLeft(List<int> inputList, string[] command)
        {
            ushort shifts = ushort.Parse(command[1]);
            int moves = shifts % inputList.Count;

            for (ushort i = 0; i < moves; i++)
            {
                int temp = inputList[0];
                inputList.RemoveAt(0);
                inputList.Add(temp);
            }
        }

        static void RemoveIntAtIndex(List<int> inputList, string[] command)
        {
            ushort indexToRemove = ushort.Parse(command[1]);
            inputList.RemoveAt(indexToRemove);
        }

        static void FindIndex(List<int> inputList, string[] command)
        {
            ushort numToFind = ushort.Parse(command[1]);
            int index = inputList.FindIndex(0, inputList.Count, x => x == numToFind);
            Console.WriteLine(index);
        }

        static void AddToList(List<int> inputList, string[] command)
        {
            ushort index = ushort.Parse(command[1]);
            int numToAdd = int.Parse(command[2]);

            inputList.Insert(index, numToAdd);
        }

        static void AddMultipleIntsToList(List<int> inputList, string[] command)
        {
            ushort index = ushort.Parse(command[1]);
            int[] numsToBeAdded = new int[command.Length - 2];
            for (ushort i = 0; i < command.Length-2; i++)
            {
                numsToBeAdded[i] = int.Parse(command[i + 2]);
            }
            inputList.InsertRange(index, numsToBeAdded);
        }
    }
}