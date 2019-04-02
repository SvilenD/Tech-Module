using System;

namespace CountIntegers
{
    class CountIntegers
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
