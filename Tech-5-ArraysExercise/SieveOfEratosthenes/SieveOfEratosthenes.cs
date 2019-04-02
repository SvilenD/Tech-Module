using System;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool[] array = new bool[input + 1];

            array = Array.ConvertAll(array, x => true);
            array[0] = false;
            array[1] = false;

            for (int i = 2; i < array.Length; i++)
            {
                for (int j = 2 * i; j < array.Length; j += i)
                {
                    array[j] = false;
                }
            }

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == true)
                {
                    Console.Write(index + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
// Алтернативен вложен цикъл
//for (int j = 2; j <= input; j++)
//{
//    if (i * j <= input)
//    {
//        array[i * j] = false;
//    }
//}