using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonTrainer
{
    private static List<Trainer> trainers = new List<Trainer>();
    public static void Main()
    {
        ReadInput();

        StartGame();

        PrintResult();
    }

    private static void PrintResult()
    {
        trainers.OrderByDescending(t => t.badges)
            .ToList()
            .ForEach(t => Console.WriteLine(t));
    }

    private static void StartGame()
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

    private static void ExecuteCommand(string currElement)
    {
        foreach (var trainer in trainers)
        {
            if (trainer.pokemons.Any(p => p.element == currElement))
            {
                trainer.badges++;
            }
            else
            {
                trainer.pokemons.ForEach(p => p.health -= 10);
                trainer.pokemons.RemoveAll(p => p.health <= 0);
            }
        }
    }

    private static void ReadInput()
    {
        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine == "Tournament")
            {
                break;
            }

            TrainerParse(inputLine);
        }
    }

    private static void TrainerParse(string inputLine)
    {
        var inputArr = inputLine
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var trainerName = inputArr[0];

        if (!trainers.Any(t => t.name == trainerName))
        {
            trainers.Add(new Trainer(trainerName));
        }

        trainers
            .Where(t => t.name == trainerName)
            .First()
            .AddPokemon(PokemonParse(inputArr));
    }

    private static Pokemon PokemonParse(string[] inputArr)
    {
        var pokemonName = inputArr[1];
        var pokemonElement = inputArr[2];
        var pokemonHealth = int.Parse(inputArr[3]);

        return new Pokemon(pokemonName, pokemonElement, pokemonHealth);
    }
}
