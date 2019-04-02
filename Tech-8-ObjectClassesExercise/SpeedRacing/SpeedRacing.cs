using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double Consumption { get; set; }
        public double TravelledDistance { get; set; }

        public static void CalculateFuel(string model, List<Car> listOfCars, double travelledDistance)
        {
            int index = listOfCars.FindIndex(x => x.Model == model);
            double FuelAmount = listOfCars[index].FuelAmount;
            double Consumption = listOfCars[index].Consumption;

            if (FuelAmount >= Consumption * travelledDistance)
            {
                listOfCars[index].FuelAmount -=  travelledDistance * Consumption;
                listOfCars[index].TravelledDistance += travelledDistance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listOfCars = new List<Car>();

            int carsCount = int.Parse(Console.ReadLine());

            string model = string.Empty;
            double fuelAmount = 0;
            double fuelConsumption = 0;
            double travelledDistance = 0;

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split();

                model = carData[0];
                fuelAmount = double.Parse(carData[1]);
                fuelConsumption = double.Parse(carData[2]);

                var car = new Car
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    Consumption = fuelConsumption,
                    TravelledDistance = travelledDistance
                };

                listOfCars.Add(car);
            }

            while (true)
            {
                string[] travelData = Console.ReadLine().Split();

                if (travelData[0] == "End")
                {
                    break;
                }

                model = travelData[1];
                travelledDistance = double.Parse(travelData[2]);
                
                Car.CalculateFuel(model, listOfCars, travelledDistance);
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}