using System;

namespace ChooseDrink2
{
    class ChooseDrink2
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string output = string.Empty;
            double price = 0;
            switch (profession)
            {
                case "Athlete":
                    output += "Water";
                    price = quantity * 0.7;  break;
                case "Businessman":
                case "Businesswoman":
                    output += "Coffee";
                    price = quantity * 1.0; break;
                case "SoftUni Student":
                    output += "Beer";
                    price = quantity * 1.7; break;
                default: output += "Tea";
                    price = quantity * 1.2; break;
            }
            Console.WriteLine($"The {profession} has to pay {price:f2}.");
        }
    }
}
