using System;

namespace StringExplosion       
{
    class Program
    {
        static void Main(string[] args)     
        {
            string input = Console.ReadLine();

            int explosionPower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    explosionPower += input[i + 1] - '0';
                    input = input.Remove(i + 1, 1); 
                    explosionPower--;
                }

                else if (explosionPower > 0)
                {
                    input = input.Remove(i, 1); 
                    explosionPower--;
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}