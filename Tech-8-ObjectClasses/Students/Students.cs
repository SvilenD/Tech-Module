using System;
using System.Collections.Generic;

namespace Students
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
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
            List<Student> studentsList = new List<Student>();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string city = input[3];

                var student = new Student(firstName, lastName, age, city);

                studentsList.Add(student);
            }

            string filterCity = Console.ReadLine();

            foreach (var student in studentsList) 
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
