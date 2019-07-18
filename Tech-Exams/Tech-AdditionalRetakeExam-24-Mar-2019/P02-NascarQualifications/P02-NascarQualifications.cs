using System;
using System.Linq;

namespace P02_NascarQualifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var standings = Console.ReadLine().Split().ToList();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                var command = input[0];
                var racer = input[1];
                if (command == "Race")
                {
                    if (standings.Contains(racer) == false)
                    {
                        standings.Add(racer);
                    }
                }
                else if (command == "Accident")
                {
                    standings.Remove(racer);
                }
                else if (command == "Box")
                {
                    if (standings.Contains(racer))
                    {
                        int position = standings.FindIndex(r => r == racer);
                        if (position < standings.Count - 1)
                        {
                            position++;
                            standings.Remove(racer);
                            standings.Insert(position, racer);
                        }
                    }
                }
                else if (command == "Overtake")
                {
                    int count = int.Parse(input[2]);
                    int position = standings.FindIndex(r => r == racer);
                    if (position - count >= 0)
                    {
                        position -= count;
                        standings.Remove(racer);
                        standings.Insert(position, racer);
                    }
                }
            }

            Console.WriteLine(string.Join(" ~ ", standings));
        }
    }
}
