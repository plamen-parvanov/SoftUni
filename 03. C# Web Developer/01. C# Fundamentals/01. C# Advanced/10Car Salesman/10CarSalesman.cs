using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<Engine> engines = new List<Engine>();
    public static List<Car> cars = new List<Car>();
    public static void Main()
    {
        ReadEnginesInput();

        ReadCarsInput();
    }

    private static void ReadCarsInput()
    {
        var carsNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < carsNum; i++)
        {
            AddCar();
        }
    }

    private static void AddCar()
    {
        var inputArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var model = inputArr[0];
        var engine = engines.Where(e => e.model == inputArr[1]).First();

        if (inputArr.Length > 3)
        {
            cars.Add(new Car(model, engine, inputArr[2], inputArr[3]));
            return;
        }
        else if (inputArr.Length < 3)
        {
            cars.Add(new Car(model, engine, "n/a", "n/a"));
            return;
        }
        else if (inputArr.Length > 2  && char.IsDigit(inputArr[2][0]))
        {
            cars.Add(new Car(model, engine, inputArr[2], "n/a"));
            return;
        }

        cars.Add(new Car(model, engine, "n/a", inputArr[2]));
    }

    private static void ReadEnginesInput()
    {
        var engineNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < engineNum; i++)
        {
            AddEngine();
        }
    }

    private static void AddEngine()
    {
        var inputArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var model = inputArr[0];
        var power = int.Parse(inputArr[1]);

        if (inputArr.Length > 3)
        {
            engines.Add(new Engine(model, power, int.Parse(inputArr[2]), inputArr[3]));
        }
        else if (inputArr.Length > 2)
        {
            int displacements;
            if (int.TryParse(inputArr[2], out displacements))
            {
                engines.Add(new Engine(model, power, displacements));
            }
            else
            {
                engines.Add(new Engine(model, power, inputArr[2]));
            }
        }
        else
        {
            engines.Add(new Engine(model, power));
        }
    }
}
