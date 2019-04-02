using System;

namespace StudentInfo
{
    class StudentInfo
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}