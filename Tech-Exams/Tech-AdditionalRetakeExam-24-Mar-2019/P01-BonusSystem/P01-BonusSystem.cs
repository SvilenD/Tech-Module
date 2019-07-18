using System;

namespace P01_BonusSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            int maxAttendances = 0;
            if (lecturesCount == 0)
            {
                Console.WriteLine($"The maximum bonus score for this course is {5 * additionalBonus}.The student has attended {maxAttendances} lectures.");
                return;
            }
            for (int i = 0; i < studentsCount; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                if (attendances >= maxAttendances)
                {
                    maxAttendances = attendances;
                }
            }

            double totalBonus = Math.Ceiling(maxAttendances / lecturesCount * (5 + additionalBonus));
            Console.WriteLine($"The maximum bonus score for this course is {totalBonus}.The student has attended {maxAttendances} lectures.");
        }
    }
}
