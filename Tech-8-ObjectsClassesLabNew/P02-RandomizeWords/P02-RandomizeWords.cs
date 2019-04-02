using System;

namespace P02_RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var array = Console.ReadLine().Split();

            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = random.Next(i, array.Length -1);
                string temp = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = temp;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
