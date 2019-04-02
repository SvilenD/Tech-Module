using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    public class Truck
    {
        public Truck(string brand, string model, int specs)
        {
            Brand = brand;
            Model = model;
            Weight = specs;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int specs)
        {
            Brand = brand;
            Model = model;
            HorsePower = specs;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalogue
    {
        public Catalogue(List<Car> listOfCars)
        {
            CarsList = listOfCars;
        }
        public Catalogue(List<Truck> listOfTrucks)
        {
            TrucksList = listOfTrucks;
        }
        public List<Car> CarsList { get; set; }
        public List<Truck> TrucksList { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listOfCars = new List<Car>();
            List<Truck> listOfTrucks = new List<Truck>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('/');

                if (input[0] == "end")
                {
                    break;
                }

                string type = input[0];
                string brand = input[1];
                string model = input[2];
                int specs = int.Parse(input[3]);

                if (type == "Car")
                {
                    Car car = new Car(brand, model, specs);
                    listOfCars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, specs);
                    listOfTrucks.Add(truck);
                }
            }
            if (listOfCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var Car in listOfCars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{Car.Brand}: {Car.Model} - {Car.HorsePower}hp");
                }

            }
            if (listOfTrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var Truck in listOfTrucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{Truck.Brand}: {Truck.Model} - {Truck.Weight}kg");
                }
            }
        }
    }
}