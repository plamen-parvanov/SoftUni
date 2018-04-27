using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication3
{
    public class Problem04
    {
        public static Dictionary<string, List<Pokemon>> dict;

        public static void Main()
        {
            dict = new Dictionary<string, List<Pokemon>>();

            ReadInput();

            PrintAllPokemons();
        }

        public static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine()
                     .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if (inputLine.Length == 1)
                {
                    if (inputLine[0] == "wubbalubbadubdub")
                    {
                        break;
                    }
                    else if (dict.ContainsKey(inputLine[0]))
                    {
                        var pokemonName = inputLine;
                        PrintAllDataFor(inputLine[0]);
                    }
                }
                else if(inputLine.Length == 3)
                {
                    AddPokemonDataFrom(inputLine);
                }
            }
        }

        public static void AddPokemonDataFrom(string[] arr)
        {
            var pokemonName = arr[0];
            var evolutionType = arr[1];
            var evolutionIndex = int.Parse(arr[2]);

            if (!dict.ContainsKey(pokemonName))
            {
                dict[pokemonName] = new List<Pokemon>();
            }

            dict[pokemonName].Add(new Pokemon(evolutionType, evolutionIndex));

        }

        public static void PrintAllDataFor(string pokemonName)
        {
            Console.WriteLine($"# {pokemonName}");
            dict[pokemonName].ForEach(x => Console.WriteLine($"{x.EvolutionType} <-> {x.EvolutionIndex}"));
        }

        public static void PrintAllPokemons()
        {
            foreach (var pokemon in dict)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var item in pokemon.Value.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                }
            }
        }
    }
}
