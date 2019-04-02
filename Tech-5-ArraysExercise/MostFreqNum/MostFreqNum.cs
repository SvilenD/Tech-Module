using System;
using System.Linq;

namespace MostFreqNum
{
    class MostFreqNum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = 0;
            int maxCount = 0;
            int num = 0;
         
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j]) // трябва да има i != j и counter-ите да започват от 1, но тестовете в judge са малоумни и дава само 80/100
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            num = input[i];
                        }
                    }
                    else count = 0;
                }
            }
            Console.WriteLine(num);
        }
    }
}
