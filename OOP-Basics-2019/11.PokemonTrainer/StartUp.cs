namespace _11.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Units;

    public class StartUp
    {
        private static List<Trainer> trainers;
        public static void Main()
        {
            CatchingPokemons();

            StartFighting();

            PrintResult();
        }

        private static void PrintResult()
        {
            trainers.OrderByDescending(t => t.Badges)
                    .ToList()
                    .ForEach(t => Console.WriteLine(t.ToString()));
        }

        private static void StartFighting()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                Fight(command);
            }
        }

        private static void Fight(string element)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == element))
                {
                    trainer.IncreaseBagdges();
                }
                else
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);

                    trainer.RemovePokemonsWithNoHealth();
                }
            }
        }

        private static void CatchingPokemons()
        {
            trainers = new List<Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                AddPokemons(command);
            }
        }

        private static void AddPokemons(string command)
        {
            var arr = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var trainerName = arr[0];
            var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

            if (trainer == null)
            {
                trainer = new Trainer(trainerName);

                trainers.Add(trainer);
            }

            var pokemon = ParsePokemon(arr.Skip(1).ToArray());

            trainer.AddPokemon(pokemon);
        }

        private static Pokemon ParsePokemon(string[] arr)
        {
            var name = arr[0];
            var element = arr[1];
            var health = int.Parse(arr[2]);

            return new Pokemon(name, element, health);
        }
    }
}
