using System;
using System.Linq;

namespace P02_PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split()
                .Select(long.Parse)
                .ToList();
            long sum = 0;
            while (elements.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index >= elements.Count)
                {
                    index = elements.Count - 1;
                    elements.Add(elements[0]);
                }
                else if (index < 0)
                {
                    index = 0;
                    elements.Insert(1, elements[elements.Count - 1]);
                }
                long num = elements[index];
                sum += num;
                elements.RemoveAt(index);
                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i] > num)
                    {
                        elements[i] -= num; 
                    }
                    else
                    {
                        elements[i] += num;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}