using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class Employee
    {

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            var employeeList = new List<Employee>();
            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];

                var employee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Department = department
                };

                employeeList.Add(employee);
            }
            string highestSalaryDep = string.Empty;
            decimal maxAverage = 0;
            
            foreach (var employee in employeeList.OrderBy(x=>x.Department))
            {
                decimal departmentAverage = 0;
                int deparmentMembersCount = employeeList.Where(x => x.Department == employee.Department).Count();

                for (int i = 0; i < deparmentMembersCount; i++)
                {
                    departmentAverage += employeeList.Where(x => x.Department == employee.Department).Average(y => y.Salary);
                }

                if (maxAverage < departmentAverage)
                {
                    maxAverage = departmentAverage;
                    highestSalaryDep = employee.Department;
                }
            }
            Console.WriteLine($"Highest Average Salary: {highestSalaryDep}");

            foreach (var employee in employeeList.Where(x => x.Department == highestSalaryDep).OrderByDescending(y => y.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
}