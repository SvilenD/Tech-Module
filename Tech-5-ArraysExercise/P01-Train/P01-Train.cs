using System;

namespace P01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] wagonsPeople = new int[numberOfWagons];
            int sum = 0;
            for (int i = 0; i < numberOfWagons; i++)
            {
                wagonsPeople[i] = int.Parse(Console.ReadLine());
                sum += wagonsPeople[i];
            }
            Console.WriteLine(string.Join(" ", wagonsPeople));
            Console.WriteLine(sum);
        }
    }
}
