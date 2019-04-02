using System;

namespace PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split();
            byte length = byte.Parse(Console.ReadLine());

            string[] added = new string[10];

            byte count = 0;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == length)
                {
                    added[count] = ingredients[i];
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    count++;
                }
                if (count > 9)
                {
                    break;
                }
            }
            string[] output = new string[count];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = added[i];
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", output)}.");
        }
    }
}
