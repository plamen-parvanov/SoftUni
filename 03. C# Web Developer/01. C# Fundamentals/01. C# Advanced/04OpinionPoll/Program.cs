using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<Person> list;
    static void Main(string[] args)
    {
        ReadInput();

        PrintPersonsWithAgeOver30();
    }

    private static void PrintPersonsWithAgeOver30()
    {
        var filtered = list.Where(x => x.Age > 30);
        filtered.OrderBy(x => x.Name).ToList().ForEach(x => Console.WriteLine(x));
    }

    private static void ReadInput()
    {
        list = new List<Person>();
        var numberOfPeople = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPeople; i++)
        {
            var currPerson = ReadPerson();
            list.Add(currPerson);
        }
    }

    private static Person ReadPerson()
    {
        var personInfo = Console.ReadLine().Split();
        var personName = personInfo[0];
        var personAge = int.Parse(personInfo[1]);

        return new Person(personName, personAge);
    }
}

