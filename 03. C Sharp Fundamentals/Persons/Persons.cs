﻿using System;
using System.Collections.Generic;
using System.Linq;
public class Persons
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
            persons.Add(person);
        }

        persons.OrderBy(p => p.FirstName)
               .ThenBy(a => a.Age)
               .ToList()
               .ForEach(p => Console.WriteLine(p.ToString()));
    }
}

