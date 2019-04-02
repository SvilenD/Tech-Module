using System;

namespace CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstString = input[0];
            string secondString = input[1];

            long sum = MultiplyChars(firstString, secondString);
            Console.WriteLine(sum);
        }

        public static long MultiplyChars (string first, string second)
        {
            long sum = 0;
            int length = Math.Max(first.Length, second.Length);
            for (int i = 0; i < length; i++)
            {
                if (i >= first.Length)
                {
                    sum += (int)second[i];
                }
                else if (i >= second.Length)
                {
                    sum += (int)first[i];
                }
                else
                {
                    sum += (int)first[i] * (int)second[i];
                }
            }

            return sum;
        }
    }
}
