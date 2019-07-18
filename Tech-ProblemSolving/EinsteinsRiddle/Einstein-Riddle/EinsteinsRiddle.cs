using System;

namespace EinsteinsRiddle
{
    class EinsteinsRiddle
    {
        static Random random = new Random();
        static string[] houses = { "Red", "Green", "Yellow", "White", "Blue" };
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Swede", "Dane", "Norwegian", "German" };
        static string[] cigarettes = { "Blend", "Prince", "Dunhill", "BlueMaster", "PallMall" };
        static string[] drinks = { "Tea", "Coffee", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];

        static void Main(string[] args)
        {
            Shuffle(houses);
            Shuffle(pets);
            Shuffle(nationalities);
            Shuffle(cigarettes);
            Shuffle(drinks);
            GenerateHints();

            Console.WriteLine("Einstein's riddle");
            Console.WriteLine("The situation");
            Console.WriteLine("1. There are 5 houses in five different colors.");
            Console.WriteLine("2. In each house lives a person with a different nationality.");
            Console.WriteLine("3. These five owners drink a certain type of beverage, smoke a certain brand of cigar and keep a certain pet.");
            Console.WriteLine("4. No owners have the same pet, smoke the same brand of cigar or drink the same beverage.");
            Console.WriteLine(Environment.NewLine + $"The Question is: Who owns the {pets[3]}?");
            Console.WriteLine("HINTS:");

            for (int i = 1; i <= hints.Length; i++)
            {
                Console.WriteLine($"{i}. {hints[i - 1]}");
            }

            Console.WriteLine("Einstein wrote this riddle last century. He said that 98% of the world could not solve it.");
            Console.WriteLine("To see the solution type \"solution\"");
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "solution")
                {
                    break;
                }
                Console.WriteLine("Wrong command, try again.");
            }
            PrintSolution();
        }

        static void Shuffle(string[] info)
        {
            for (int i = 0; i < info.Length; i++)
            {
                int randomItem = i + random.Next(0, info.Length - i);
                string temp = info[i];
                info[i] = info[randomItem];
                info[randomItem] = temp;
            }
        }

        static void GenerateHints()
        {
            hints[0] = $"The {nationalities[0]}, lives in the {houses[0]} house.";
            hints[1] = $"The {nationalities[1]} keeps {pets[0]} as pets.";
            hints[2] = $"The {nationalities[3]} drinks {drinks[1]}.";
            hints[3] = $"{houses[1]} is on the left of the {houses[4]} house.";
            hints[4] = $"The {houses[1]} house owner drinks {drinks[2]}.";
            hints[5] = $"The person who smokes {cigarettes[4]} rears {pets[2]}.";
            hints[6] = $"The owner of the {houses[2]} house smokes {cigarettes[2]}";
            hints[7] = $"The man living in the center house drinks {drinks[2]}.";
            hints[8] = $"The {nationalities[4]} lives in the first house.";
            hints[9] = $"The man who smokes {cigarettes[0]} lives next to the one who keeps {pets[2]}.";
            hints[10] = $"The man who keeps {pets[4]} lives next to the man who smokes {cigarettes[2]}.";
            hints[11] = $"The owner who smokes {cigarettes[4]} drinks {drinks[3]}.";
            hints[12] = $"The {nationalities[4]} smokes {cigarettes[2]}.";
            hints[13] = $"The {nationalities[3]} lives next to the {houses[4]} house.";
            hints[14] = $"The man who smokes {cigarettes[0]} has a neighbour who drinks {drinks[4]}.";
        }

        private static void PrintSolution()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}. In the {houses[i]} lives the {nationalities[i]}.");
                Console.WriteLine($"He drinks {drinks[i]}, smokes {cigarettes[i]} and has {pets[i]} as a pet.");
            }
        }
    }
}