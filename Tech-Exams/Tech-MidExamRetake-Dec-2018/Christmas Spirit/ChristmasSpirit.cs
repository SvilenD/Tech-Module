using System;

namespace Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());

            int spirit = 0;

            int ornamentSet = 2;
            int TreeSkirt = 5;
            int TreeGarlands = 3;
            int TreeLights = 15;
            int moneySpent = 0;

            for (int day = 1; day <= daysLeft; day++)
            {
                bool moreSpirit = false;

                if (day % 11 == 0)
                {
                    quantity += 2;
                }

                if (day % 2 == 0 )
                {
                    moneySpent += ornamentSet * quantity;
                    spirit += 5;
                }

                if (day % 3 == 0)
                {
                    moneySpent += (TreeSkirt + TreeGarlands) * quantity;
                  
                    spirit += 13;
                    moreSpirit = true;
                }

                if (day % 5 == 0)
                {
                    moneySpent += TreeLights * quantity;
                    
                    spirit += 17;
                    if (moreSpirit)
                    {
                        spirit += 30;
                    }
                }

                if (day % 10 == 0)
                {
                    spirit -= 20;
                    if (daysLeft == day)
                    {
                        spirit -= 30;
                    }
                    moneySpent += TreeSkirt + TreeGarlands + TreeLights;
                }
            }
            Console.WriteLine($"Total cost: {moneySpent}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}