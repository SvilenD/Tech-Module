using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string line = command.Trim();
            command = line.Split(' ').First();
            int[] args = new int[2];

            if (command.Equals("add") || command.Equals("subtract") || command.Equals("multiply"))
            {
                string[] stringParams = line.Split(' ');
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                array = PerformAction(array, command, args);
            }
            else if (command.Equals("lshift") || command.Equals("rshift"))
            {
                array = PerformAction(array, command, args);
            }

            PrintArray(array);

            command = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        long pos = args[0];
        long value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos - 1] *= value;
                break;
            case "add":
                array[pos - 1] += value;
                break;
            case "subtract":
                array[pos - 1] -= value;
                break;
            case "lshift":
                array = ArrayShiftLeft(array);
                break;
            case "rshift":
                array = ArrayShiftRight(array);
                break;
        }
        return array;
    }

    private static long[] ArrayShiftRight(long[] array)
    {
        long[] shifted = new long[array.Length];
        shifted[0] = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            shifted[i] = array[i - 1];
        }
        return shifted;
    }

    private static long[] ArrayShiftLeft(long[] array)
    {
        long[] shifted = new long[array.Length];
        shifted[shifted.Length - 1] = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            shifted[i] = array[i + 1];
        }
        return shifted;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}