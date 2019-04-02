using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numsList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool go = true;
            while (go)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                switch (command[0])
                {
                    case "Delete":
                        int numToRemove = int.Parse(command[1]);
                        numsList.RemoveAll(x => x == numToRemove);
                        break;
                    case "Insert":
                        int num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numsList.Insert(index, num);
                        break;
                    case "Odd":
                        foreach (int item in numsList)
                        {
                            if (item % 2 != 0)
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        Console.WriteLine();
                            go = false;
                            break;
                    case "Even":
                        foreach (int item in numsList)
                        {
                            if (item % 2 == 0)
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        Console.WriteLine();
                        go = false;
                        break;
                }
            }
        }
    }
}
