using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_OrderByAge
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var personsList = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }
                var name = input[0];
                var id = input[1];
                var age = int.Parse(input[2]);

                var person = new Person(name, id, age);
                personsList.Add(person);
            }

            foreach (var person in personsList.OrderBy(x=>x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
