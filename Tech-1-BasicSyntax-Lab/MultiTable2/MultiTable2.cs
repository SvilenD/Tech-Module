using System;

namespace MultiTable2
{
    class MultiTable2
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            byte count = byte.Parse(Console.ReadLine());
            int result = 0;
            if (count > 10)
            {
                result = num * count;
                Console.WriteLine($"{num} X {count} = {result}");
            }
            for (int i = count; count <= 10; count++)
            {
                 result= num * count;
                Console.WriteLine($"{num} X {count} = {result}");
            }
        }
    }
}