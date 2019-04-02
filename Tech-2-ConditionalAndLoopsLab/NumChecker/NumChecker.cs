using System;

namespace NumChecker
{
    class NumChecker
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!"); 
            }
        }
    }
}
