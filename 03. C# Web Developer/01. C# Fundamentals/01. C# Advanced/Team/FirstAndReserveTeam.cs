using System;
using System.Collections.Generic;

public class FirstAndReserveTeam
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                                    cmdArgs[1],
                                    int.Parse(cmdArgs[2]),
                                    double.Parse(cmdArgs[3]));

            persons.Add(person);
        }

        var team = new Team("pesho");

        persons.ForEach(p => team.AddPlayer(p));

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");


    }
}

