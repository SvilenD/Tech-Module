using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var elements = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToList();

        long sum = 0;

        while (elements.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());

            long currentElement = 0;

            if (index < 0)
            {
                currentElement = elements[0];
                elements[0] = elements[elements.Count - 1];
            }
            else if (index >= elements.Count)
            {
                currentElement = elements[elements.Count - 1];
                elements[elements.Count - 1] = elements[0];
            }
            else
            {
                currentElement = elements[index];
                elements.RemoveAt(index);
            }

            IncreaseDecreaseElementsValue(currentElement, elements);

            sum += currentElement;
        }
        Console.WriteLine(sum);
    }

    private static void IncreaseDecreaseElementsValue(long currentElement, List<long> elements)
    {
        for (int i = 0; i < elements.Count; i++)
        {
            if (elements[i] <= currentElement)
            {
                elements[i] += currentElement;
            }
            else
            {
                elements[i] -= currentElement;
            }
        }
    }
}