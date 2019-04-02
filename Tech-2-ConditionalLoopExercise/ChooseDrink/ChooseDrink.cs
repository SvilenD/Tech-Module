using System;

namespace ChooseDrink
{
    class ChooseDrink
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();

            string output = string.Empty;
            switch (profession)
            {
                case "athlete": output += "Water"; break;
                case "businessman":     
                case "businesswoman": output += "Coffee"; break;
                case "softuni student": output += "Beer"; break;
                default: output += "Tea"; break;
            }
            Console.WriteLine(output);
        }
    }
}
