using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            var studentsList = new List<Student>();
            for (int i = 0; i < length; i++)
            {
                var input = Console.ReadLine().Split();

                var student = new Student
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Grade = double.Parse(input[2])
                };
                studentsList.Add(student);
            }
            foreach (var student in studentsList.OrderByDescending(x=>x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
