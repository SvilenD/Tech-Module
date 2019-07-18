using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            var schedule = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToList();

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "course start")
                {
                    break;
                }
                string course = input[1];
                if (input[0] == "Add")
                {
                    if (!schedule.Contains(course))
                    {
                        schedule.Add(course);
                    }
                }
                else if (input[0] == "Insert")
                {
                    int index = int.Parse(input[2]);
                    if (!schedule.Contains(course) && (index >= 0 && index < schedule.Count))
                    {
                        schedule.Insert(index, course);
                    }
                }
                else if (input[0] == "Remove")
                {
                    schedule.Remove(course);
                    schedule.Remove(course + "-Exercise");
                }
                else if (input[0] == "Swap")
                {
                    string otherCourse = input[2];
                    SwapLessons(schedule, course, otherCourse);
                }
                else if (input[0] == "Exercise")
                {
                    AddExersice(schedule, course);
                }
            }
            int count = 1;
            foreach (var course in schedule)
            {
                Console.WriteLine($"{count}.{course}");
                count++;
            }
        }

        static void AddExersice(List<string> schedule, string course)
        {
            if (schedule.Contains(course))
            {
                schedule.Insert(schedule.IndexOf(course) + 1, course + "-Exercise");
            }
            else
            {
                schedule.Add(course);
                schedule.Add(course + "-Exercise");
            }
        }

        static void SwapLessons(List<string> schedule, string course, string otherCourse)
        {
            if (schedule.Contains(course) && schedule.Contains(otherCourse))
            {
                int firstIndex = schedule.IndexOf(course);
                int secondIndex = schedule.IndexOf(otherCourse);
                schedule[firstIndex] = otherCourse;
                schedule[secondIndex] = course;

                if (schedule.Contains(course + "-Exercise"))
                {
                    schedule.Remove(course + "-Exercise");
                    schedule.Insert(schedule.IndexOf(course) + 1, course + "-Exercise");
                }
                if (schedule.Contains(otherCourse + "-Exercise"))
                {
                    schedule.Remove(otherCourse + "-Exercise");
                    schedule.Insert(schedule.IndexOf(otherCourse) + 1, otherCourse + "-Exercise");
                }
            }
        }
    }
}