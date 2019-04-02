using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Car
    {
        public Car (string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

    }

    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    public class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var listOfCars = new List<Car>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                var engine = new Engine()
                {
                    Speed = engineSpeed,
                    Power = enginePower
                };

                var cargo = new Cargo()
                {
                    Weight = cargoWeight,
                    Type = cargoType
                };

                var car = new Car(model, engine, cargo);
                listOfCars.Add(car);
            }
            string filter = Console.ReadLine();

            if (filter == "fragile")
            {
                foreach (var car in listOfCars.Where(x => x.Cargo.Type == filter).Where(y => y.Cargo.Weight < 1000))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                foreach (var car in listOfCars.Where(x => x.Cargo.Type == filter).Where(y => y.Engine.Power > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
