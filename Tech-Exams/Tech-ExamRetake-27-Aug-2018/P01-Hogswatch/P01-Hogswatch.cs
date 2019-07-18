using System;

namespace P01_Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfHomes = int.Parse(Console.ReadLine());
            int presents = int.Parse(Console.ReadLine());
            int presentsNow = presents;
            int additionalPresents = 0;
            int timesWentBack = 0;
            for (int index = 1; index <= numOfHomes; index++)
            {
                int children = int.Parse(Console.ReadLine());

                presentsNow -= children;
                if (presentsNow < 0)
                {
                    int newPresents = (presents / index) * (numOfHomes - index) - presentsNow;
                    presentsNow += newPresents;
                    additionalPresents += newPresents;
                    timesWentBack++;
                }
            }
            if (additionalPresents > 0)
            {
                Console.WriteLine(timesWentBack);
                Console.WriteLine(additionalPresents);
            }
            else
            {
                Console.WriteLine(presentsNow);
            }
        }
    }
}
