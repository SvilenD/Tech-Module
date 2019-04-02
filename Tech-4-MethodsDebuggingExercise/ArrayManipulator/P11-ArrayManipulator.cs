using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", array)}]");
                    return;
                }

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        if (index < 0 || index >= array.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            ExchangeArray(array, index);
                        }
                        break;

                    case "max":
                        string oddOrEven = command[1];
                        int maxIndex = MaxIndex(array, oddOrEven);

                        if (maxIndex > -1)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "min":
                        oddOrEven = command[1];
                        int minIndex = MinIndex(array, oddOrEven);

                        if (minIndex > -1)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "first":
                        int count = int.Parse(command[1]);
                        oddOrEven = command[2];

                        if (count < 0 || count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            var firstNums = FirstOddEvenNumbers(array, oddOrEven, count);
                            Console.WriteLine($"[{string.Join(", ", firstNums)}]");
                        }
                        break;

                    case "last":
                        count = int.Parse(command[1]);
                        oddOrEven = command[2];

                        if (count < 0 || count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            var lastNums = LastOddEvenNumbers(array, oddOrEven, count);
                            Console.WriteLine($"[{string.Join(", ", lastNums)}]");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        static void ExchangeArray(int[] array, int index)
        {
            var newArray = new int[array.Length];

            for (int i = 0; i < array.Length - 1 - index; i++)
            {
                newArray[i] = array[index + 1 + i];
            }
            int num = 0;
            for (int i = array.Length - index - 1; i < newArray.Length; i++)
            {
                newArray[i] = array[num];
                num++;
            }
            newArray.CopyTo(array, 0);
        }

        static int MaxIndex(int[] array, string command)
        {
            int maxIndex = -1;
            int maxNum = int.MinValue;
            bool maxEven = true;

            if (command == "odd")
            {
                maxEven = false;
            }

            for (int index = 0; index < array.Length; index++)
            {
                int number = array[index];
                if (maxEven)
                {
                    if (number % 2 == 0 && number >= maxNum)
                    {
                        maxNum = number;
                        maxIndex = index;
                    }
                }

                else
                {
                    if (number % 2 !=0 && number >= maxNum)
                    {
                        maxNum = number;
                        maxIndex = index;
                    }
                }
            }
            return maxIndex;
        }

        static int MinIndex(int[] array, string command)
        {
            int minIndex = -1;
            int minNum = int.MaxValue;
            bool minEven = true;

            if (command == "odd")
            {
                minEven = false;
            }

            for (int index = 0; index < array.Length; index++)
            {
                int number = array[index];
                if (minEven)
                {
                    if (number % 2 == 0 && number <= minNum)
                    {
                        minNum = number;
                        minIndex = index;
                    }
                }

                else
                {
                    if (number % 2 != 0 && number <= minNum)
                    {
                        minNum = number;
                        minIndex = index;
                    }
                }
            }
            return minIndex;
        }

        static List<int> FirstOddEvenNumbers(int[] array, string command, int count)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (command == "even" && array[i] % 2 == 0)
                {
                    result.Add(array[i]);
                    count--;
                }
                else if (command == "odd" && array[i] % 2 != 0)
                {
                    result.Add(array[i]);
                    count--;
                }
                if (count == 0)
                {
                    break;
                }
            }
            return result;
        }

        static List<int> LastOddEvenNumbers(int[] array, string command, int count)
        {
            List<int> result = new List<int>();

            for (int i = array.Length - 1; i >=0; i--)
            {
                if (command == "even" && array[i] % 2 == 0)
                {
                    result.Add(array[i]);
                }
                else if (command == "odd" && array[i] % 2 != 0)
                {
                    result.Insert(0, array[i]);
                    count--;
                }
                if (count == 0)
                {
                    break;
                }
            }
            return result;
        }
    }
}