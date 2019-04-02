using System;

namespace P12.RefactorSpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            

            for (int index = 1; index <= number; index++)
            {
                bool isSpecial = false;
                int current = index;
                int total = 0;
                while (current > 0)
                {
                    total += current % 10;
                    current = current / 10;
                }

                if ((total == 5) || (total == 7) || (total == 11))
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{index} -> {isSpecial}");
            }
        }
    }
}
