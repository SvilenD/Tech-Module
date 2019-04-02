using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            List<int> numbers = new List<int>();

            for (int index = 0; index < input.Length; index++)
            {
                if (!input[index].Equals(string.Empty))
                {
                    int num = int.Parse(input[index]);
                    numbers.Add(num);
                }
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    found = true;
                    Console.Write(currentNum);
                    Console.Write(" ");
                }
                else if (j < numbers.Count - 1)
                {
                    currentNum += numbers[j + 1];
                    j++;

                    if (currentNum >= 0)
                    {
                        Console.Write(currentNum);
                        Console.Write(" ");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }
            else Console.WriteLine();
        }
    }
}