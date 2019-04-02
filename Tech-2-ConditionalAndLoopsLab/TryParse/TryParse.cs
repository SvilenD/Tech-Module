using System;

namespace TryParse
{
    class TryParse
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result;
            bool success = int.TryParse(input, out result);
            if (success)
            {
                Console.WriteLine("It's a number");
                //Console.WriteLine(result);
            }
            else Console.WriteLine("Invalid entry");
        }
    }
}
