using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    public class Family 
    {
        public Family (Person person, List<Person> personList)
        {
            this.PersonList = new List<Person>();
            this.Person = person;
        }
        public List<Person> PersonList { get; set; }
        public Person Person { get; set; }

        public static void AddMember(List<Person> PersonList, Person person)
        {
            PersonList.Add(person);
        }

        public static Person GetOldestMember(List<Person> PersonList)
        {
            Person OldestMember = PersonList.OrderByDescending(x =>x.Age).FirstOrDefault();
            return OldestMember; 
        }

    }

    public class Person
    {
        public Person (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int membersCount = int.Parse(Console.ReadLine());

            List<Person> personList = new List<Person>();
            for (int i = 0; i < membersCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                var person = new Person(name, age);
                Family.AddMember(personList, person);
            }
            Person oldest = Family.GetOldestMember(personList);
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}