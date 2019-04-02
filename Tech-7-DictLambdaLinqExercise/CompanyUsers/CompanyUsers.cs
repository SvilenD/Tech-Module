using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepReceiving = true;

            Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();

            while (keepReceiving)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    keepReceiving = false;
                    break;
                }

                string[] userInput = input
                    .Split(" -> ")
                    .ToArray();
                string companyName = userInput[0];
                string employeeID = userInput[1];
                if (companyData.ContainsKey(companyName))
                {
                    if (!companyData[companyName].Contains(employeeID))
                    {
                        companyData[companyName].Add(employeeID);
                    }
                }
                else
                {
                    List<string> employees = new List<string>();
                    employees.Add(employeeID);
                    companyData.Add(companyName, employees);
                }
            }

            var result = companyData.OrderBy(x => x.Key);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key}");
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }
            }
        }
    }
}