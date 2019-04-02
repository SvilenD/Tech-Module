using System;
using System.Linq;

namespace P04_ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            if (rotations > 0)
            {
                int[] rotated = new int[input.Length];

                for (int i = 0; i < rotations; i++)
                {
                    rotated = RotateArray(input);
                    input = rotated;
                }

                Console.WriteLine(string.Join(" ", rotated));
            }
            else
            {
                Console.WriteLine(string.Join(" ", input));
            }
        }

        static int[] RotateArray(int[] input)
        {
            int[] rotated = new int[input.Length];

            for (int i = 0; i < rotated.Length - 1; i++)
            {
                rotated[i] = input[i + 1];
            }
            rotated[input.Length - 1] = input[0];

            return rotated;
        }
    }
}
