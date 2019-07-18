using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            var database = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numOfLines; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                AddToDatabase(input, database);
            }

            string[] query = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string extension = "." + query[0];
            string root = query[2];

            if (!database.ContainsKey(root))
            {
                Console.WriteLine("No");
            }
            else if (!database[root].Any(x => x.Key.Contains(extension)))
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in database[root].OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                {
                    if (file.Key.Contains(extension))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
        }

        private static void AddToDatabase(string[] input, Dictionary<string, Dictionary<string, long>> database)
        {
            string root = input[0];

            string[] file = input[input.Count() - 1].Split(';');
            string fileName = file[0];
            long size = long.Parse(file[1]);

            if (!database.ContainsKey(root))
            {
                database.Add(root, new Dictionary<string, long>());
            }

            if (!database[root].ContainsKey(fileName))
            {
                database[root].Add(fileName, size);
            }
            else
            {
                database[root][fileName] = size;
            }
        }
    }
}
