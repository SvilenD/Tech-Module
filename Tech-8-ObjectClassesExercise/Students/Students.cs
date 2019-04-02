using System;
using System.Collections.Generic;
using System.Linq;

namespace Students

{
    public class Student
    {
        public Student (string firstName, string lastName, double grade)
            {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] inputData = Console.ReadLine().Split();

                string firstName = inputData[0];
                string lastName = inputData[1];
                double grade = double.Parse(inputData[2]);

                var student = new Student(firstName, lastName, grade);
                listOfStudents.Add(student);
            }

            foreach (var student in listOfStudents.OrderByDescending(x =>x.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }
}