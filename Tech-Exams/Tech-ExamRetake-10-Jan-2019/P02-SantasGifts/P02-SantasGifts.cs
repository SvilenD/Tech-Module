using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SantasGifts
{
    class Program
    {
        static int psn = 0;
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            var houses = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Forward")
                {
                    int steps = int.Parse(command[1]);
                    MoveAndRemove(houses, steps);
                }
                else if (command[0] == "Back")
                {
                    int steps = int.Parse(command[1]) * -1;
                    MoveAndRemove(houses, steps);
                }
                else if (command[0] == "Gift")
                {
                    AddNewHouse(houses, command);
                }
                else if (command[0] == "Swap")
                {
                    SwapHouses(houses, command);
                }
            }

            Console.WriteLine($"Position: {psn}");
            Console.WriteLine(string.Join(", ", houses));
        }

        static void MoveAndRemove(List<int> houses, int steps)
        {
            if (psn + steps >= 0 && psn + steps < houses.Count)
            {
                psn += steps;
                houses.RemoveAt(psn);
            }
        }

        static void AddNewHouse(List<int> houses, string[] command)
        {
            int index = int.Parse(command[1]);
            if (index >= 0 && index < houses.Count)
            {
                int num = int.Parse(command[2]);
                houses.Insert(index, num);
                psn = index;
            }
        }

        static void SwapHouses(List<int> houses, string[] command)
        {
            int firstNum = int.Parse(command[1]);
            int secondNum = int.Parse(command[2]);
            int firstIndex = houses.IndexOf(firstNum);
            int secondIndex = houses.IndexOf(secondNum);
            if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < houses.Count && secondIndex < houses.Count)
            {
                int temp = houses[firstIndex];
                houses[firstIndex] = houses[secondIndex];
                houses[secondIndex] = temp;
            }
        }
    }
}
