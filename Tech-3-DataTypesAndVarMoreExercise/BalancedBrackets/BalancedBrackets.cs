using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            bool nextIsLeft = true;
            bool nextIsRight = false;
            int leftCount = 0;
            int rightCount = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(" && nextIsLeft)
                {
                    nextIsLeft = false;
                    nextIsRight = true;
                    leftCount++;
                }
                else if (input == ")" && nextIsRight)
                {
                    nextIsRight = false;
                    nextIsLeft = true;
                    rightCount++;
                }
                else if (input.Contains("(") || input.Contains(")"))
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (leftCount == rightCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}