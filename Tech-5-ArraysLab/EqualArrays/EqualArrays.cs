using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    return;
                }
            }
            int sum = firstArray.Sum();
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
