using System;
using System.Linq;

namespace ExtractMidElements
{
    class ExtractMidElements
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
            }
            else if (array.Length % 2 == 0)
            {
                PrintMidFmEvenArray(array);
            }
            else if (array.Length % 2 != 0)
            {
                PrintMidFmOddArray(array);
            }
        }

        private static void PrintMidFmOddArray(int[] array)
        {
            Console.WriteLine($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]}, {array[array.Length / 2 + 1]} }}");
        }

        private static void PrintMidFmEvenArray(int[] array)
        {
            Console.WriteLine($"{{ {array[array.Length / 2 - 1]}, {array[array.Length / 2]} }}");
        }
    }
}