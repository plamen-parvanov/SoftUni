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
            ReadInput();

            PrintResult();
        }

        private static void PrintResult()
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "fragile":
                    PrintFragile();
                    break;
                case "flamable":
                    PrintFlamable();
                    break;
            }
        }

        private static void PrintFlamable()
        {
            cars.Where(c => c.Cargo.CargoType == "flamable")
                .Where(c => c.Engine.EnginePower > 250)
                .ToList()
                .ForEach(c => Console.WriteLine(c.Model));
        }

        private static void PrintFragile()
        {
            cars.Where(c => c.Cargo.CargoType == "fragile")
                .Where(c => c.Tires.Any(t => t.TirePressure < 1))
                .ToList()
                .ForEach(c => Console.WriteLine(c.Model));
        }

        private static void ReadInput()
        {
            cars = new List<Car>();
            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                AddCarInList(Console.ReadLine());
            }
        }

        private static void AddCarInList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var model = inputArr[0];
            var engineSpeed = int.Parse(inputArr[1]);
            var enginePower = int.Parse(inputArr[2]);
            var cargoWeight = int.Parse(inputArr[3]);
            var cargoType = inputArr[4];
            var tire1Pressure = double.Parse(inputArr[5]);
            var tire1Age = int.Parse(inputArr[6]);
            var tire2Pressure = double.Parse(inputArr[7]);
            var tire2Age = int.Parse(inputArr[8]);
            var tire3Pressure = double.Parse(inputArr[9]);
            var tire3Age = int.Parse(inputArr[10]);
            var tire4Pressure = double.Parse(inputArr[11]);
            var tire4Age = int.Parse(inputArr[12]);

            var currentCar = new Car(model, engineSpeed, enginePower, cargoWeight,
                cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                tire3Pressure, tire3Age, tire4Pressure, tire4Age);

            cars.Add(currentCar);
        }
    }
}
