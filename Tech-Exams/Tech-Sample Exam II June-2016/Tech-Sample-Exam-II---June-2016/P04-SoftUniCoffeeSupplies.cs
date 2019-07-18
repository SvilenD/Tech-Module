namespace P04_SoftUniCoffeeSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Coffee
    {
        public Coffee(string name, string person, int quantity = 0)
        {
            this.Name = name;

            this.Consumers = new List<string>();
            if (!Consumers.Contains(person) && person != string.Empty)
            {
                Consumers.Add(person);
            }

            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public List<string> Consumers { get; set; }

        public int Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] delimiters = Console.ReadLine().Split();

            List<Coffee> coffeeData = new List<Coffee>();

            while (true)    // receiving data
            {
                string input = Console.ReadLine();

                if (input == "end of info")
                {
                    break;
                }

                else if (input.Contains(delimiters[0]))
                {
                    string delimiter = delimiters[0];
                    PersonalDataInput(delimiter, input, coffeeData);
                }
                else if (input.Contains(delimiters[1]))
                {
                    string delimiter = delimiters[1];
                    CoffeeQuantityInput(delimiter, input, coffeeData);
                }
            }

            PrintOutOfStock(coffeeData);
            
            while (true)        //consumptions
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end of week")
                {
                    break;
                }

                AddConsumptions(input, coffeeData);
            }

            PrintStockLeftForCustomers(coffeeData);
        }

        private static void PersonalDataInput(string delimiter, string input, List<Coffee>coffeeData)
        {
            var personalTypes = input.Split(new string[] {delimiter},StringSplitOptions.RemoveEmptyEntries); 

            string person = personalTypes[0];
            string coffeeName = personalTypes[1];

            if (!coffeeData.Select(x => x.Name).Contains(coffeeName))
            {
                Coffee coffee = new Coffee(coffeeName, person);
                coffeeData.Add(coffee);
            }
            else if (!coffeeData.Any(x=>x.Consumers.Equals(person)))
            {
                int coffeeIndex = coffeeData.FindIndex(x => x.Name == coffeeName);
                coffeeData[coffeeIndex].Consumers.Add(person);
            }
        }

        private static void CoffeeQuantityInput(string delimiter, string input, List<Coffee> coffeeData)
        {
            var coffeeQuantity = input.Split(new string[] {delimiter}, StringSplitOptions.RemoveEmptyEntries);

            string coffeeName = coffeeQuantity[0];
            int quantity = int.Parse(coffeeQuantity[1]);

            if (!coffeeData.Any(x =>x.Name.Equals(coffeeName)))
            {
                Coffee coffee = new Coffee(coffeeName,string.Empty,quantity);
                coffeeData.Add(coffee);
            }
            else
            {
                int coffeeIndex = coffeeData.FindIndex(x => x.Name == coffeeName);
                coffeeData[coffeeIndex].Quantity += quantity;
            }
        }

        private static void PrintOutOfStock(List<Coffee> coffeeData)
        {
                List<Coffee> outOfStock = coffeeData.FindAll(x => x.Quantity <= 0);
                foreach (var coffee in outOfStock)
                {
                    Console.WriteLine($"Out of {coffee.Name}");
                }
        }

        private static void AddConsumptions(string input, List<Coffee> coffeeData)
        {
            string[] info = input.Split();
            string person = info[0];
            int consumption = int.Parse(info[1]);

            int index = coffeeData.FindIndex(x => x.Consumers.Contains(person));

            coffeeData[index].Quantity -= consumption;

            if (coffeeData[index].Quantity <= 0)
            {
                Console.WriteLine($"Out of {coffeeData[index].Name}");
            }
        }

        private static void PrintStockLeftForCustomers(List<Coffee> coffeeData)
        {
            Console.WriteLine("Coffee Left:");
            foreach (var coffee in coffeeData.Where(x => x.Quantity > 0).OrderByDescending(x=>x.Quantity))
            {
                Console.WriteLine($"{coffee.Name} {coffee.Quantity}");
            }

            Console.WriteLine("For:");

            foreach (var coffee in coffeeData.Where(x => x.Quantity > 0).OrderBy(x=>x.Name))
            {
                List<string> consumers = coffee.Consumers;

                consumers = consumers.OrderByDescending(x=>x).ToList();
                for (int i = 0; i < consumers.Count; i++)
                {
                    Console.WriteLine($"{consumers[i]} {coffee.Name}");
                }
            }
        }
    }
}