using System;

namespace DifferentNums
{
    class DifferentNums
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 - num1 < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = num1; n1 <= num2 - 4; n1++)
                {
                    for (int n2 = n1 + 1; n2 <= num2 - 3; n2++)
                    {
                        for (int n3 = n1 + 2; n3 <= num2 - 2; n3++)
                        {
                            for (int n4 = n1 + 3; n4 <= num2 - 1; n4++)
                            {
                                for (int n5 = n1 + 4; n5 <= num2; n5++)
                                {
                                    if (n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5)
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}