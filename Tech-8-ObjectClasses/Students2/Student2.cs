using System;
using System.Collections.Generic;

namespace Students2
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.City = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Student> ListOfStudents = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                if (IsStudentExisting(ListOfStudents, firstName, lastName))
                {
                    Student student = GetStudent(ListOfStudents, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = homeTown;
                }
                else
                {
                    var student = new Student(firstName, lastName, age, homeTown);
                    ListOfStudents.Add(student);
                }
            }

            string city = Console.ReadLine();

            foreach (var student in ListOfStudents)
            {
                if (student.City == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> listOfStudents, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (var student in listOfStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        static bool IsStudentExisting (List<Student> listOfStudents, string name, string family )
        {
            bool isExisting = false;

            foreach (var student in listOfStudents)
            {
                if (student.FirstName == name && student.LastName == family)
                {
                    isExisting = true;
                }
            }

            return isExisting;
        }
    }
}