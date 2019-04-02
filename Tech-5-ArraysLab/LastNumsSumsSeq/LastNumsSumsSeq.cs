using System;

namespace LastNumsSumsSeq
{
    class LastNumsSumsSeq
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int kSequence = int.Parse(Console.ReadLine());

            long[] array = new long[length];

            array[0] = 1;

            for (int index = 1; index < length; index++)
            {
                long sum = 0;

                for (int i = index - kSequence; i <= index - 1; i++)
                {
                    if (i >= 0)
                    {
                        sum += array[i];
                    }
                    array[index] = sum;
                }
            }
            for (int index = 0; index < length; index++)
            {
                Console.Write(array[index] + " ");
            }
            Console.WriteLine();
        }
    }
}
