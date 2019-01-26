using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        private static List<Car> cars;
        public static void Main()
        {
            AddAllCars();

            DriveCars();

            PrintResult();
        }

        private static void PrintResult()
        {
            cars.ForEach(c => Console.WriteLine(c.ToString()));
        }

        private static void DriveCars()
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                TryToMoveCar(input);
            }
        }

        private static void TryToMoveCar(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = inputArr[1];
            var amountKm = int.Parse(inputArr[2]);

            var currnetCar = cars.FirstOrDefault(c => c.Model == model);

            if (!currnetCar.CanMove(amountKm))
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        private static void AddAllCars()
        {
            cars = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                 var curretCar = CarParse(Console.ReadLine());

                cars.Add(curretCar);
            }
        }

        private static Car CarParse(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = inputArr[0];
            var fuelAmount = decimal.Parse(inputArr[1]);
            var fuelConsumption = decimal.Parse(inputArr[2]);

            return new Car(model, fuelAmount, fuelConsumption);
        }
    }
}
