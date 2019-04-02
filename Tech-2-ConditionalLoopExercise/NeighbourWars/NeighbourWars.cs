using System;

namespace NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());

            int peshosHealth = 100;
            int goshosHealth = 100;
            int roundCounter = 1;

            while (peshosHealth > 0 && goshosHealth > 0)
            {
                if (roundCounter % 2 != 0)
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {roundCounter}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }
                else
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {roundCounter}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                if (roundCounter % 3 == 0)
                {
                    goshosHealth += 10;
                    peshosHealth += 10;
                }
                roundCounter++;
            }
        }
    }
}