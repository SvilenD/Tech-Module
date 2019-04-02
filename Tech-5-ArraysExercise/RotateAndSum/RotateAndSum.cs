using System;
using System.Linq;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[input.Length];

            for (int i = 0; i < rotations; i++)
            {
                int[] rotated = RotateArray(input);

                if (i > 0)
                {
                    sum = SumArray(sum, rotated);
                }
                else
                {
                    sum = rotated;
                }

                input = rotated;
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        static int[] RotateArray(int[] input)
        {
            int[] rotated = new int[input.Length];

            for (int index = 1; index < input.Length; index++)
            {
                rotated[index] = input[index - 1];
            }
            rotated[0] = input[input.Length - 1];

            return rotated;
        }

        static int[] SumArray(int[] input, int[] rotated)
        {
            int[] sum = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                sum[i] = input[i] + rotated[i];
            }
            return sum;
        }
    }
}