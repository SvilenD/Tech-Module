using System;

namespace PadawanEquipment
{
    class PadawanEquip
    {
        static void Main(string[] args)
        {
            decimal money = decimal. Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal lightSabrePrice = decimal. Parse(Console.ReadLine());
            decimal robePrice = decimal. Parse(Console.ReadLine());
            decimal beltPrice = decimal. Parse(Console.ReadLine());
            decimal lightSabres = (decimal)Math.Ceiling(students * 1.1) * lightSabrePrice;
            decimal robes = robePrice * students;
            decimal belts = 0;
            if (students >= 6) belts = (students - students / 6) * beltPrice;
            else belts = students * beltPrice;
            decimal expenses = lightSabres + belts + robes;
            if (money >= expenses)
            {
                Console.WriteLine($"The money is enough - it would cost {expenses:f2}lv.");
            }
            else Console.WriteLine($"Ivan Cho will need {(expenses - money):f2}lv more.");
        }
    }
}