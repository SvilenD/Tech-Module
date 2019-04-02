using System;
using System.Linq;


namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Trim().Split();
            string[] second = Console.ReadLine().Trim().Split();

            int commonStraight = ArrayCommonEnd(first, second);
            
            Array.Reverse(first);
            Array.Reverse(second);

            int commonReversed = ArrayCommonEnd(first, second);

            int output = Math.Max(commonStraight, commonReversed);
            Console.WriteLine(output);
        }

        static int ArrayCommonEnd(string[]first, string[]second)
        {
            int count = 0;
            int maxCount = 0;
            int minLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (first[i] == second[i])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else count = 0;
            }

            return maxCount;
        }
    }
}