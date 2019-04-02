using System;

namespace ReverseIntArray
{
    class ReverseIntArray
    {
        public static object PrintReverse { get; private set; }

        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] array = InitializeArray(length);
            PrintReversedArray(array);
        }

        static int[] InitializeArray(int length)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        static void PrintReversedArray(int[] array)
        {
            for (int i = array.Length -1; i >=0 ; i--)
            {
                Console.Write(array[i]+" "); 
            }
            Console.WriteLine();
        }
    }
}