using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SoftUniCoursePlanning
{
    class Program
    {
        static int index = 1;
        static void Main(string[] args)
        {
            var schedule = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "course start")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        if (!schedule.Contains(command[1]))
                        {
                            schedule.Add(command[1]);
                        }
                        break;

                    case "Insert":
                        index = int.Parse(command[2]);
                        if (!schedule.Contains(command[1]) && (index >= 0 && index < schedule.Count))
                        {
                            schedule.Insert(index, command[1]);
                        }
                        break;

                    case "Remove":
                        schedule.Remove(command[1]);
                        schedule.Remove(command[1] + "-Exercise");
                        break;

                    case "Swap":
                        if (schedule.Contains(command[1]) && schedule.Contains(command[2]))
                        {
                            SwapCourses(command, schedule);
                        }
                        break;

                    case "Exercise":
                        IncludeExercise(command, schedule);
                        break;
                }
            }

            index = 1;
            foreach (var course in schedule)
            {
                Console.WriteLine($"{index}.{course}");
                index++;
            }
        }

        private static void IncludeExercise(string[] command, List<string> schedule)
        {
            if (schedule.Contains(command[1]) && !schedule.Contains(command[1] + "-Exercise"))
            {
                index = schedule.IndexOf(command[1]);
                schedule.Insert(index + 1, command[1] + "-Exercise");
            }
            else if (!schedule.Contains(command[1]))
            {
                schedule.Add(command[1]);
                schedule.Add(command[1] + "-Exercise");
            }
        }

        private static void SwapCourses(string[] command, List<string> schedule)
        {
            int firstIndex = schedule.IndexOf(command[1]);
            int secondIndex = schedule.IndexOf(command[2]);
            schedule[firstIndex] = command[2];
            schedule[secondIndex] = command[1];

            if (schedule.Contains(command[1] + "-Excercise"))
            {
                schedule.Remove(command[1] + "-Exercise");
                firstIndex = schedule.IndexOf(command[1]);
                schedule.Insert(firstIndex + 1, command[1] + "-Exercise");
            }
            else if (schedule.Contains(command[2] + "-Exercise"))
            {
                schedule.Remove(command[2] + "-Exercise");
                secondIndex = schedule.IndexOf(command[2]);
                schedule.Insert(secondIndex + 1, command[2] + "-Exercise");
            }
        }
    }
}