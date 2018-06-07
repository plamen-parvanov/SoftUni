using System;
using System.Collections.Generic;
using System.Linq;

public class Google
{
    private static List<Person> people = new List<Person>();
    public static void Main()
    {
        ReadInput();

        Print();
    }

    private static void Print()
    {
        var inputName = Console.ReadLine();
        var person = people.First(p => p.name == inputName);

        Console.WriteLine(person);
    }

    private static void ReadInput()
    {
        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine == "End")
            {
                break;
            }

            ExecuteCommand(inputLine);
        }
    }

    private static void ExecuteCommand(string inputLine)
    {
        var inputArr = inputLine
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var currName = inputArr[0];

        if (!people.Any(p => p.name == currName))
        {
            people.Add(new Person(currName));
        }

        AddInfo(inputArr);

    }

    private static void AddInfo(string[] inputArr)
    {
        var currName = inputArr[0];
        var currPerson = people.First(p => p.name == currName);

        var info = inputArr[1];

        switch (info)
        {
            case "company":
                AddCompany(inputArr.Skip(2).ToArray(), currPerson);
                break;
            case "car":
                AddCarr(inputArr.Skip(2).ToArray(), currPerson);
                break;
            case "parents":
                AddParent(inputArr.Skip(2).ToArray(), currPerson);
                break;
            case "children":
                AddChildren(inputArr.Skip(2).ToArray(), currPerson);
                break;
            case "pokemon":
                AddPokemon(inputArr.Skip(2).ToArray(), currPerson);
                break;
        }
    }

    private static void AddPokemon(string[] arr, Person currPerson)
    {
        var pokemonName = arr[0];
        var pokemonType = arr[1];

        currPerson.AddPokemon(new Pokemon(pokemonName, pokemonType));
    }

    private static void AddChildren(string[] arr, Person currPerson)
    {
        var childName = arr[0];
        var childBirthday = arr[1];

        currPerson.AddChild(new Children(childName, childBirthday));
    }

    private static void AddParent(string[] arr, Person currPerson)
    {
        var parentName = arr[0];
        var parentBirthday = arr[1];

        currPerson.AddParent(new Parent(parentName, parentBirthday));
    }

    private static void AddCarr(string[] arr, Person currPerson)
    {
        var carModel = arr[0];
        var carSpeed = int.Parse(arr[1]);

        currPerson.AddCar(new Car(carModel, carSpeed));
    }

    private static void AddCompany(string[] arr, Person currPerson)
    {
        var companyName = arr[0];
        var department = arr[1];
        var salary = decimal.Parse(arr[2]);

        currPerson.AddCompany(new Company(companyName, department, salary));
    }
}
