using System;

namespace StringToBoolean
{
    class StringToBoolean
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool result = Convert.ToBoolean(input);
            if (result == true)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}