using System;

namespace DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            int roomsCount = 0;

            string[] rooms = Console.ReadLine().Split("|");
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] data = rooms[i].Split();

                roomsCount++;
                string item = data[0];
                int number = int.Parse(data[1]);
                if (item == "potion")
                {
                    if (health + number <= 100)
                    {
                        health += number;
                    }
                    else
                    {
                        number = 100 - health;
                        health = 100;
                    }
                    Console.WriteLine("You healed for {0} hp.", number);
                    Console.WriteLine("Current health: {0} hp.", health);
                }
                else if (item == "chest")
                {
                    Console.WriteLine("You found {0} coins.", number);
                    coins += number;
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {item}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {item}.");
                        Console.WriteLine($"Best room: {roomsCount}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!{Environment.NewLine}Coins: {coins}{Environment.NewLine}Health: {health}");
        }
    }
}