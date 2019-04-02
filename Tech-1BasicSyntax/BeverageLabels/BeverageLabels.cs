using System;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int enegryContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine(volume*enegryContent/100.0+"kcal, "+ volume*sugarContent/100.0+"g sugars");
        }
    }
}