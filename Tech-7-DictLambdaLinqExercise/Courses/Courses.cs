using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool receiveInfo = true;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (receiveInfo)
            {
                string[] input = Console.ReadLine()
                    .Split(" : ")
                    .ToArray();
                if (input[0] == "end")
                {
                    receiveInfo = false;
                    break;
                }
                string courseName = input[0];
                
                if (!courses.ContainsKey(courseName))
                {
                    List<string> students = new List<string>();
                    students.Add(input[1]);
                    courses.Add(courseName, students);
                }
                else
                {
                    courses[courseName].Add(input[1]);
                }
            }

            PrintResult(courses);
        }

        private static void PrintResult(Dictionary<string, List<string>> courses)
        {
            var coursesOrdered = courses.OrderByDescending(x => x.Value.Count());
            foreach (var kvp in coursesOrdered)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                string[] studentsOrdered = kvp.Value.OrderBy(a => a).ToArray();
                for (int i = 0; i < studentsOrdered.Length; i++)
                {
                    Console.WriteLine($"-- {studentsOrdered[i]}");
                }
            }
        }
    }
}