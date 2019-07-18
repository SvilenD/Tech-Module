using System;
using System.Linq;

namespace P02_ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }

                string command = input[0];

                switch (command)
                {
                    case "swap": SwapArrayElements(array, input);
                        break;
                    case "multiply": MultiplyElement(array, input);
                        break;
                    case "decrease": DecreaseAllElemnts(array);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }

        static void DecreaseAllElemnts(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }
        }

        static void MultiplyElement(long[] array, string[] input)
        {
            int firstIndex = int.Parse(input[1]);
            int secondIndex = int.Parse(input[2]);

            array[firstIndex] *= array[secondIndex];
        }

        static void SwapArrayElements(long[] array, string[]input)
        {
            int firstIndex = int.Parse(input[1]);
            int secondIndex = int.Parse(input[2]);

            long temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}
