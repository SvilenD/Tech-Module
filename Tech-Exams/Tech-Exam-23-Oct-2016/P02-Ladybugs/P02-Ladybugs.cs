using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] field = new int[length];

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < indexes.Length; i++)
            {
                int num = indexes[i];
                if (num >= 0 && num < field.Length)
                {
                    field[num] = 1;
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] splitted = command.Split();
                int startIndex = int.Parse(splitted[0]);
                int flightLength = int.Parse(splitted[2]);
                string direction = splitted[1];

                if (startIndex >= 0 && startIndex < field.Length && field[startIndex] == 1)
                {
                    field[startIndex] = 0;

                    if (direction == "left")
                    {
                        int position = startIndex - flightLength;
                        for (int i = position; i >= 0; i -= flightLength)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }

                    else if (direction == "right")
                    {
                        int position = startIndex + flightLength;
                        for (int i = position; i < field.Length; i += flightLength)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}