using System;
using System.Linq;

namespace P03_LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            var paintingsNum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Change")
                {
                    int oldNum = int.Parse(command[1]);
                    int newNum = int.Parse(command[2]);
                    if (paintingsNum.Contains(oldNum))
                    {
                        int index = paintingsNum.FindIndex(x => x == oldNum);
                        paintingsNum[index] = newNum;
                    }
                }
                else if (command[0] == "Hide")
                {
                    int num = int.Parse(command[1]);
                    paintingsNum.Remove(num);
                }
                else if (command[0] == "Switch")
                {
                    int firstNum = int.Parse(command[1]);
                    int secondNum = int.Parse(command[2]);
                    if (paintingsNum.Contains(firstNum) && paintingsNum.Contains(secondNum))
                    {
                        int firstIndex = paintingsNum.FindIndex(x => x == firstNum);
                        int secondIndex = paintingsNum.FindIndex(x => x == secondNum);
                        paintingsNum[firstIndex] = secondNum;
                        paintingsNum[secondIndex] = firstNum;
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < paintingsNum.Count)
                    {
                        index += 1;
                        int num = int.Parse(command[2]);
                        paintingsNum.Insert(index, num);
                    }
                }
                else if (command[0] == "Reverse")
                {
                    paintingsNum.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", paintingsNum));
        }
    }
}