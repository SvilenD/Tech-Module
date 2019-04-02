using System;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people =    int.Parse(Console.ReadLine());
            double capacity =  double.Parse(Console.ReadLine());
            double result = Math.Ceiling(people / capacity);
            Console.WriteLine(result);
        }
    }
}