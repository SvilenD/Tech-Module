using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numsList = Console.ReadLine()
                .Trim()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine().Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0].ToLower() == "end")
                {
                    break;
                }
                else if (command[0].ToLower() == "delete")
                {
                    long numToRemove = long.Parse(command[1]);
                    //for (int i = 0; i < numsList.Count; i++) 
                    //{
                    //    if (numsList[i] == numToRemove)
                    //    {
                    //        numsList.RemoveAt(i);
                    //    }
                    //}
                    numsList.RemoveAll(x=>x == numToRemove);
                }
                else if (command[0].ToLower() == "insert")
                {
                    long num = long.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index >= 0 && index <= numsList.Count)
                    {
                        numsList.Insert(index, num);
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numsList));
        }
    }
}