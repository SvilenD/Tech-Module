using System;

namespace RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int countHeadset = lostGames / 2;
            int countMouse = lostGames / 3;
            int countKeyboard = lostGames / 6;
            int countDislay = countKeyboard / 2;
            double expenses = countHeadset * headsetPrice + countMouse * mousePrice
                + countKeyboard * keyboardPrice + countDislay * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}