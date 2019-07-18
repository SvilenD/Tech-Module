using System;
using System.Linq;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Stop")
                {
                    break;
                }
                else if (command[0] == "Delete") //OK
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < input.Count - 1)
                    {
                        index += 1;
                        input.RemoveAt(index);
                    }
                }
                else if (command[0] == "Swap")
                {
                    var first = command[1];
                    var second = command[2];
                    if (input.Contains(first) && input.Any(y => y == second))
                    {
                        int firstIndex = input.FindIndex(x => x == first);
                        int secondIndex = input.FindIndex(y => y == second);
                        input[firstIndex] = second;
                        input[secondIndex] = first;
                    }
                }
                else if (command[0] == "Put") //OK
                {
                    var word = command[1];
                    int index = int.Parse(command[2]) - 1;
                    if (index >= 0 && index <= input.Count)
                    {
                        input.Insert(index, word);
                    }
                }
                else if (command[0] == "Sort") //OK
                {
                    input.Sort();
                    input.Reverse();
                }
                else if (command[0] == "Replace") //OK
                {
                    var first = command[1];
                    var second = command[2];
                    if (input.Any(x => x == second))
                    {
                        int index = input.FindIndex(x => x == second);
                        input[index] = first;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}