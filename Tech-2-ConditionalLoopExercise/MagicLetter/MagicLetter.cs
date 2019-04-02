using System;

namespace MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char exception = char.Parse(Console.ReadLine());

            for (char a = start; a <= end; a++)
            {
                for (char b = start; b <= end; b++)
                {
                    for (char c = start; c <= end; c++)
                    {
                        if (a != exception && b !=exception && c!=exception)
                        {
                        Console.Write($"{a}{b}{c} ");
                        }
                    }
                }
            }
        }
    }
}
