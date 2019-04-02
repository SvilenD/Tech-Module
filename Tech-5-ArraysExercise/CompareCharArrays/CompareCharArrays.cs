using System;
using System.Linq;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            int minLength = Math.Min(firstArray.Length, secondArray.Length);

            bool first = false;
            bool same = true;
            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    first = true;
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    break;
                } 
            }
            if (firstArray.Length < secondArray.Length && same)
            {
                first = true;
            }
            if (first)
            {
                Console.WriteLine(string.Join("", firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else 
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }

        }
    }
}