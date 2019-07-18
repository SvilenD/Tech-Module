using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MatrixOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            var content = new Dictionary<int, List<int>>();
            for (int i = 0; i < rowsCount; i++)
            {
                var row = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();
                content.Add(i, row);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }

                string command = input[0];
                switch (command)
                {
                    case "remove": RemoveElements(input, content);
                        break;
                    case "swap": SwapRows(input, content);
                        break;
                    case "insert": InsertInBegOfGivenRow(input, content);
                        break;
                }
            }

            foreach (var row in content)
            {
                Console.WriteLine(string.Join(" ", row.Value));
            }
        }

        private static void InsertInBegOfGivenRow(string[] input, Dictionary<int, List<int>> content)
        {
            int row = int.Parse(input[1]);
            int number = int.Parse(input[2]);

            content[row].Insert(0, number);
        }

        private static void SwapRows(string[] input, Dictionary<int, List<int>> content)
        {
            int firstRow = int.Parse(input[1]);
            int secondRow = int.Parse(input[2]);

            List<int> temp = content[firstRow];
            content[firstRow] = content[secondRow];
            content[secondRow] = temp;
        }

        private static void RemoveElements(string[] input, Dictionary<int, List<int>> content)
        {
            string type = input[1].ToLower();
            string place = input[2].ToLower();
            int position = int.Parse(input[3]);

            switch (type)
            {
                case "positive":
                    if (place == "row")
                    {
                        content[position].RemoveAll(x => x >= 0);   //judge stupidos thinking that 0 is positive number! 
                    }
                    else if (place == "col")
                    {
                        for (int row = 0; row < content.Keys.Count; row++)
                        {
                            if (content[row].Count > position)
                            {
                                if (content[row][position] >= 0)
                                {
                                    content[row].RemoveAt(position);
                                }
                            }
                        }
                    }
                    break;

                case "negative":
                    if (place == "row")
                    {
                        content[position].RemoveAll(x => x < 0);
                    }
                    else if (place == "col")
                    {
                        for (int row = 0; row < content.Keys.Count; row++)
                        {
                            if (content[row].Count > position)
                            {
                                if (content[row][position] < 0)
                                {
                                    content[row].RemoveAt(position);
                                }
                            }
                        }
                    }
                    break;

                case "even":
                    if (place == "row")
                    {
                        content[position].RemoveAll(x => x % 2 == 0);
                    }
                    else if (place == "col")
                    {
                        for (int row = 0; row < content.Keys.Count; row++)
                        {
                            if (content[row].Count > position)
                            {
                                if (content[row][position] % 2 == 0)
                                {
                                    content[row].RemoveAt(position);
                                }
                            }
                        }
                    }
                    break;

                case "odd":
                    if (place == "row")
                    {
                        content[position].RemoveAll(x => x % 2 != 0);
                    }
                    else if (place == "col")
                    {
                        for (int row = 0; row < content.Keys.Count; row++)
                        {
                            if (content[row].Count > position)
                            {
                                if (content[row][position] % 2 != 0)
                                {
                                    content[row].RemoveAt(position);
                                }
                            }
                        }
                    }
                    break;
            }
        }
    }
}