namespace DefiningClasses
{
    using DefiningClasses.Units;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Engine> engines;
        private static List<Car> cars;
        public static void Main()
        {
            ReadEngines();

            ReadCars();

            PrintAllCars();
        }

        private static void PrintAllCars()
        {
            cars.ForEach(c => Console.WriteLine(c.ToString()));
        }

        private static void ReadCars()
        {
            cars = new List<Car>();

            var numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                var inputLine = Console.ReadLine();

                var currentCar = ParseCar(inputLine);

                cars.Add(currentCar);
            }
        }

        private static Car ParseCar(string inputLine)
        {
            var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = arr[0];
            var engine = engines.FirstOrDefault(e => e.Model == arr[1]);

            Car car;

            if (arr.Length == 2)
            {
                car = new Car(model, engine);
            }
            else if (arr.Length == 3)
            {
                car = new Car(model, engine, arr[2]);
            }
            else
            {
                car = new Car(model, engine, arr[2], arr[3]);
            }

            return car;
        }

        private static void ReadEngines()
        {
            engines = new List<Engine>();

            var numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                var inputLine = Console.ReadLine();

                var currentEngine = ParseEngine(inputLine);

                engines.Add(currentEngine);
            }
        }

        private static Engine ParseEngine(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = arr[0];
            var power = arr[1];
            Engine engine;

            if (arr.Length == 4)
            {
                engine = new Engine(model, power, arr[2], arr[3]);
            }
            else if (arr.Length == 3)
            {
                engine = new Engine(model, power, arr[2]);
            }
            else
            {
                engine = new Engine(model, power);
            }

            return engine;
        }
    }
}
