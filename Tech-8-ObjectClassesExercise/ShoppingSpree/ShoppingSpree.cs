using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> BagOfProducts { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            List<Product> listOfProducts = new List<Product>();

            string[] peopleData = Console.ReadLine().Split(';');

            for (int i = 0; i < peopleData.Length; i++)
            {
                string[] personalData = peopleData[i].Split("=");

                string name = personalData[0];
                decimal money = decimal.Parse(personalData[1]);

                var person = new Person()
                {
                    Name = name,
                    Money = money,
                    BagOfProducts = new List<Product>()
                };
                listOfPersons.Add(person);
            }

            string[] productsData = Console.ReadLine().Split(';');

            for (int i = 0; i < productsData.Length; i++)
            {
                string[] item = productsData[i].Split('=');
                if (productsData[i] == "")
                {
                    break;
                }
                string name = item[0];
                decimal price = decimal.Parse(item[1]);

                var product = new Product()
                {
                    Name = name,
                    Price = price
                };
                listOfProducts.Add(product);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0].ToLower() == "end")
                {
                    break;
                }

                string customer = command[0];
                string requiredProduct = command[1];

                int customerIndex = listOfPersons.FindIndex(x => x.Name == customer);
                int productIndex = listOfProducts.FindIndex(x => x.Name == requiredProduct);
                if (listOfPersons[customerIndex].Money >= listOfProducts[productIndex].Price)
                {
                    listOfPersons[customerIndex].Money -= listOfProducts[productIndex].Price;

                    Console.WriteLine($"{customer} bought {requiredProduct}");

                    listOfPersons[customerIndex].BagOfProducts.Add(listOfProducts[productIndex]);
                }
                else
                {
                    Console.WriteLine($"{customer} can't afford {requiredProduct}");
                }
            }

            foreach (var person in listOfPersons)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.Write($"{person.Name} - ");
                    Console.WriteLine(string.Join(", ", person.BagOfProducts.Select(x => x.Name)));
                }

                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}