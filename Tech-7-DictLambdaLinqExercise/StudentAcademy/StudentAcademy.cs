using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputPairs = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputPairs; i++)
            {
                string studentName = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(currentGrade);
                }
                else
                {
                    List<double> grades = new List<double>();
                    grades.Add(currentGrade);
                    students.Add(studentName, grades);
                }
            }

            Dictionary<string, List<double>>  filteredStudents = students
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(y => y.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in filteredStudents)
            {
                double averageGrade = kvp.Value.Average();
                Console.WriteLine($"{kvp.Key} -> {averageGrade:f2}");
            }
        }
    }
}