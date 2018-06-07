using System;
using System.Collections.Generic;

public class SpeedRacing
{
    public static Dictionary<string, Car> cars;
    public static void Main()
    {
        ReadInput();

        ExecuteCommands();

        PrintAllCars();
    }

    private static void PrintAllCars()
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car.Value.ToString());
        }
    }

    private static void ExecuteCommands()
    {
        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine == "End")
            {
                break;
            }

            DriveCar(inputLine);
        }
    }

    private static void DriveCar(string inputLine)
    {
        var arr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var currCar = cars[arr[1]];
        var amountOfKm = double.Parse(arr[2]);

        if (currCar.CanMoveThatDistance(amountOfKm))
        {
            currCar.MovingTheCar(amountOfKm);
            return;
        }

        Console.WriteLine("Insufficient fuel for the drive");
    }

    private static void ReadInput()
    {
        cars = new Dictionary<string, Car>();

        var numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            ReadInputLine();
        }
    }

    private static void ReadInputLine()
    {
        var inputArr = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
       
        var model = inputArr[0];
        var fuelAmount = double.Parse(inputArr[1]);
        var fuelConsumptionPerKm = double.Parse(inputArr[2]);

        var currCar = new Car(model, fuelAmount, fuelConsumptionPerKm);

        cars.Add(model, currCar);
    }
}
