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

                var currentStudent = new Student(firstName, lastName, age, homeTown);

                bool exists = false;
                int index = 0;
                foreach (Student student in listOfStudents)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        index = listOfStudents.IndexOf(student);
                        exists = true;
                    }
                }
                if (exists)
                {
                    listOfStudents[index] = currentStudent;
                }

                else
                {
                    listOfStudents.Add(currentStudent);
                }
            }

            string town = Console.ReadLine();

            foreach (var student in listOfStudents.Where(x => x.HomeTown == town))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

    }
}

