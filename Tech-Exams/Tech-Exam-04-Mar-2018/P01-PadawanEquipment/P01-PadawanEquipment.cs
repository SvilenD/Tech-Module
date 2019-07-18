using System;

namespace P01_PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());

            int lightsaberCount = (int)Math.Ceiling(students * 1.1);
            int beltsCount = students - students / 6;

            decimal expenses = lightsaberPrice * lightsaberCount + robePrice * students + beltsCount * beltPrice;

            if (money >= expenses)
            {
                Console.WriteLine($"The money is enough - it would cost {expenses:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(expenses - money):f2}lv more.");
            }
        }
    }
}
