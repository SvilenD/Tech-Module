using System;
using System.Linq;

namespace P04_TrifonQuest
{
    class Program
    {
        static long health;     // с инт не минава да ми .....майката
        static int rowsLength;
        static int colsLength;
        static int turnsCount;

        static void Main(string[] args)
        {
            health = long.Parse(Console.ReadLine());
            int[] size = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            char[,] map = new char[size[0], size[1]];

            rowsLength = size[0];
            colsLength = size[1];

            InitializeMap(size, map);

            MoveThroughMap(map);
        }

        private static void MoveThroughMap(char[,] map)
        {
            for (int col = 0; col < colsLength; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < rowsLength; row++)
                    {
                        char symbol = map[row, col];
                        if (symbol == 'F')
                        {
                            health -= turnsCount / 2;
                        }
                        else if (symbol == 'H')
                        {
                            health += turnsCount / 3;
                        }
                        else if (symbol == 'T')
                        {
                            turnsCount += 2;
                        }
                        if (health <= 0)
                        {
                            Console.WriteLine($"Died at: [{row}, {col}]");
                            return;
                        }
                        turnsCount++;
                    }
                }
                else
                {
                    for (int row = rowsLength - 1; row >= 0; row--)
                    {
                        char symbol = map[row, col];
                        if (symbol == 'F')
                        {
                            health -= turnsCount / 2;
                        }
                        else if (symbol == 'H')
                        {
                            health += turnsCount / 3;
                        }
                        else if (symbol == 'T')
                        {
                            turnsCount += 2;
                        }
                        if (health <= 0)
                        {
                            Console.WriteLine($"Died at: [{row}, {col}]");
                            return;
                        }
                        turnsCount++;
                    }
                }
            }
            PrintIfSuccess();
        }
        
        private static void InitializeMap(int[] size, char[,] map)
        {
            for (int row = 0; row < rowsLength; row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < line.Length; col++)
                {
                    map[row, col] = line[col];
                }
            }
        }

        private static void PrintIfSuccess()
        {
            Console.WriteLine("Quest completed!");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Turns: {turnsCount}");
        }
    }
}