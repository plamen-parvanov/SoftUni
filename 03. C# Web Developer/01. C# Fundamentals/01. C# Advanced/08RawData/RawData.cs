using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    public static List<Car> cars;
    public static void Main()
    {
        ReadInput();

        ExecuteCommand();
    }

    private static void ExecuteCommand()
    {
        var command = Console.ReadLine();

        if (command == "fragile")
        {
            PrintFragile();
        }
        else if (command == "flamable")
        {
            PrintFlamable();
        }
    }

    private static void PrintFlamable()
    {
        foreach (var car in cars.Where(x => x.engine.enginePower> 250))
        {
            Console.WriteLine(car.model);
        }
    }

    private static void PrintFragile()
    {
        foreach (var car in cars.Where(x => x.tires.Any(t => t.tirePressure < 1)))
        {
            Console.WriteLine(car.model);
        }
    }

    private static void ReadInput()
    {
        cars = new List<Car>();

        var numbersOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbersOfCars; i++)
        {
            ReadInputLine();
        }
    }

    private static void ReadInputLine()
    {
        var inputArr = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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

        cars.Add(new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
            tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age,
            tire4Pressure, tire4Age));
    }
}
