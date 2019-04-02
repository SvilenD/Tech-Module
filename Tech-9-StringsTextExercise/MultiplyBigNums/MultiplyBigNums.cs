using System;

namespace MultiplyBigNums  
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0'); //махане на водещи нули
            int multiplier = int.Parse(Console.ReadLine());

            string reversed = string.Empty;
            int remaining = 0;
            if (number == "0" || multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(number[i].ToString());

                int numberToAdd = digit * multiplier + remaining;
                remaining = numberToAdd / 10;

                if (numberToAdd > 9)
                {
                    reversed += numberToAdd % 10;
                }
                else
                {
                    reversed += numberToAdd;
                }
            }
            if (remaining != 0)
            {
                reversed += remaining;
            }
            string result = string.Empty;

            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                result += reversed[i];
            }

            Console.WriteLine(result);
        }
    }
}