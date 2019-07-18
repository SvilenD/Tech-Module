using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static Dictionary<string, int> examResults = new Dictionary<string, int>();
        static Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }
                var command = input.Split('-');

                if (command[1] == "banned")
                {
                    string student = command[0];
                    examResults.Remove(student);
                }
                else
                {
                    LanguageData(command[1]);
                    StudentsData(command);
                }
            }

            Console.WriteLine("Results:");
            foreach (var kvp in examResults.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kvp in languageSubmissions.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }

        static void LanguageData(string language)
        {
            if (!languageSubmissions.ContainsKey(language))
            {
                languageSubmissions.Add(language, 0);
            }

            languageSubmissions[language]++;
        }

        static void StudentsData(string[] command)
        {
            string student = command[0];
            int points = int.Parse(command[2]);
            if (!examResults.ContainsKey(student))
            {
                examResults.Add(student, points);
            }
            else if (points > examResults[student])
            {
                examResults[student] = points;
            }
        }
    }
}