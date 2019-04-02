using System;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Bake!")
                {
                    break;
                }
                count++;
                Console.WriteLine($"Adding ingredient {input}.");
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}