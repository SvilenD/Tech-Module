using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Students2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }
                var firstName = input[0];
                var lastName = input[1];
                int age = int.Parse(input[2]);
                var homeTown = input[3];

                var student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                if (listOfStudents.Any(x => x.FirstName == firstName && x.LastName == lastName))
                {
                    int index = listOfStudents.FindIndex(x => x.FirstName == firstName && x.LastName == lastName);
                    listOfStudents[index] = student;
                }
                else
                {
                    listOfStudents.Add(student);
                }
            }
            string town = Console.ReadLine();
            listOfStudents = listOfStudents.Where(x => x.HomeTown == town).ToList();
            foreach (var student in listOfStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

    }
}

