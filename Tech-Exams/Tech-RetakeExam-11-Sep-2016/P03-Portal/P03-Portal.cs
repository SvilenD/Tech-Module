using System;

namespace P03_Portal
{
    class Program
    {
        static int currentRow = 0;
        static int currentCol = 0;
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            char[][] map = new char[numberOfLines][];

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                map[i] = new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    map[i][j] = input[j];
                    if (input[j] == 'S')
                    {
                        currentRow = i;
                        currentCol = j;
                    }
                }
            }

            string directions = Console.ReadLine();
            for (int i = 0; i < directions.Length; i++)
            {
                char move = directions[i];
                if (move == 'D')
                {
                    MoveDown(map, move);
                }
                else if (move == 'L')
                {
                    MoveLeft(map, move);
                }
                else if (move == 'R')
                {
                    MoveRight(map, move);
                }
                else if (move == 'U')
                {
                    MoveUp(map, move);
                }
                if (map[currentRow][currentCol] == 'E')
                {
                    Console.WriteLine($"Experiment successful. {i + 1} turns required.");
                    return;
                }
            }
            Console.WriteLine($"Robot stuck at {currentRow} {currentCol}. Experiment failed.");
        }

        static void MoveUp(char[][] map, char move)
        {
            while (true)
            {
                currentRow--;
                if (currentRow < 0)
                {
                    currentRow = map.GetLength(0) - 1;
                }
                if (currentCol < map[currentRow].Length)
                {
                    break;
                }
            }
        }//OK

        static void MoveLeft(char[][] map, char move)
        {
            while (true)
            {
                currentCol--;
                if (currentCol < 0)
                {
                    currentCol = map[currentRow].Length - 1;
                }
                break;
            }
        }

        static void MoveRight(char[][] map, char move)
        {
            while (true)
            {
                currentCol++;
                if (currentCol > map[currentRow].Length - 1)
                {
                    currentCol = 0;
                }
                break;
            }
        }

        static void MoveDown(char[][] map, char move) //OK
        {
            while (true)
            {
                currentRow++;
                if (map.GetLength(0) <= currentRow)
                {
                    currentRow = 0;
                }
                if (map[currentRow].Length > currentCol)
                {
                    break;
                }
            }
        }
    }
}
