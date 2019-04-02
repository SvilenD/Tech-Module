using System;
using System.Linq;

namespace P01_EncryptSortPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            char[] vowels = new char[] { 'a', 'A', 'e','E', 'i', 'I', 'o', 'O', 'u', 'U'};
            int[] result = new int[number];

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                int sum = 0;
                for (int index = 0; index < input.Length; index++)
                {
                    char symbol = input[index];
                    if (vowels.Contains(symbol))
                    {
                        sum += symbol * input.Length;
                    }
                    else
                    {
                        sum += symbol / input.Length;
                    }
                }
                result[i] = sum;
            }
            result = result.OrderBy(x => x).ToArray();

            foreach (var sum in result)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
