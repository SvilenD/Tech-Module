using System;
using System.Collections.Generic;
using System.Linq;

namespace Student2Linq
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            if (age < 1) // optional
            {
                while (age<1)
                {
                Console.Write("Age must be more than 0." + Environment.NewLine + "Enter valid age:");
                age = int.Parse(Console.ReadLine());
                this.Age = age;
                }
            }
            this.City = city;
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
            List<Student> listOfStudents = new List<Student>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string city = input[3];

                IsExisting(listOfStudents, firstName, lastName, age, city);
            }

            string filterCity = Console.ReadLine();

            foreach (var student in listOfStudents)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        public static Student IsExisting(List<Student> listOfStudents, string firstName, string lastName, int age, string city)
        {
            Student student = listOfStudents.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student == null)
            {
                student = new Student(firstName, lastName, age, city);
                listOfStudents.Add(student);
            }
            else
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.City = city;
            }

            return student;
        }
    }
}