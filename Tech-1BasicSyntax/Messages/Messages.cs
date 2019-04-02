using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string message = string.Empty;
            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int lastDigit = number % 10;
                int numToAdd = 0;

                switch (lastDigit)
                {
                    case 3: numToAdd = 2; break;
                    case 4: numToAdd = 4; break;
                    case 5: numToAdd = 6; break;
                    case 6: numToAdd = 8; break;
                    case 7: numToAdd = 10; break;
                    case 8: numToAdd = 13; break;
                    case 9: numToAdd = 15; break;
                    case 0: numToAdd = -63; break;
                    default:
                        break;
                }
                char next = ' ';
                if (number < 10)
                {
                    next = (char)(lastDigit + numToAdd + 95);
                }
                else if (number < 100)
                {
                    next = (char)(lastDigit + numToAdd + 96);
                }
                else if (number < 1000)
                {
                    next = (char)(lastDigit + numToAdd + 97);
                }
                else
                {
                    next = (char)(lastDigit + numToAdd + 98);
                }
                message += next;

            }
            Console.WriteLine(message);
        }
    }
}