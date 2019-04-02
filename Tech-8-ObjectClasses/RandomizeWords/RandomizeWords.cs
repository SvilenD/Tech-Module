using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            Random random = new Random();

            for (int index = 0; index < words.Length; index++)
            {
                int randomIndex = random.Next(0, words.Length);

                string tempValue = words[index];
                words[index] = words[randomIndex];
                words[randomIndex] = tempValue;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));        }
    }
}