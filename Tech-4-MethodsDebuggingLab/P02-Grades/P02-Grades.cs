using System;

namespace P02_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            PrintGrade(grade);
        }

        static void PrintGrade(double grade)
        {
            string output = string.Empty;
            if (grade >= 2 && grade  < 3)
            {
                output = "Fail";
            }
            else if (grade < 3.5)
            {
                output = "Poor";
            }
            else if (grade < 4.5)
            {
                output = "Good";
            }
            else if (grade < 5.5)
            {
                output = "Very good";
            }
            else if (grade >= 5.5 && grade <= 6.00)
            {
                output = "Excellent";
            }

            Console.WriteLine(output);
        }

    }
}
