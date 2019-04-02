using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByAge
{
    public class Person
    {
        public Person (string name, string idNum, int age)
        {
            this.Name = name;
            this.ID = idNum;
            this.Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personsList = new List<Person>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                string idNum = input[1];
                int age = int.Parse(input[2]);

                var person = new Person(name, idNum, age);
                personsList.Add(person);
            }

            foreach (var person in personsList.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}