namespace _04.Pokemon_Evolution
{

    using System;
    using System.Collections.Generic;
    using System.Linq;




    public class Pokemon
    {

        private string type;
        private int index;

        public Pokemon(string type, int index)
        {

            this.type = type;
            this.index = index;
        }



        public string Type
        {
            get { return this.type; }
            set { }
        }

        public int Index
        {
            get { return this.index; }
            set { }
        }




    }

    public class ExamPartII
    {

        public static void Main()
        {
            var pokemonDict = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command.Equals("wubbalubbadubdub"))
                {
                    break;
                }

                var commandArr = command
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                var pokemonName = commandArr[0];

                if (commandArr.Length == 1 && pokemonDict.ContainsKey(pokemonName))
                {

                    PrintPokemon(pokemonName, pokemonDict);
                    continue;
                }
                if (commandArr.Length ==1)
                {
                    continue;
                }

                
                var pokemonType = commandArr[1];
                var pokemonIndex = int.Parse(commandArr[2]);

                var currentPokemont = new Pokemon(pokemonType, pokemonIndex);
                if (!pokemonDict.ContainsKey(pokemonName))
                {
                    pokemonDict[pokemonName] = new List<Pokemon>();
                }
                pokemonDict[pokemonName].Add(currentPokemont);

            }

            PrintAllPokemons(pokemonDict);
           
        }

       public static void PrintPokemon(string name, Dictionary<string, List<Pokemon>> dict)
        {
         
            Console.WriteLine($"# {name}");
            foreach (var pokemon in dict[name])
            {
                Console.WriteLine($"{pokemon.Type} <-> {pokemon.Index}");
            }
        
        }


        public static void PrintAllPokemons(Dictionary<string, List<Pokemon>> dict)
        {

            foreach (var pokemonList in dict)
            {
                Console.WriteLine($"# {pokemonList.Key}");
                var a = pokemonList.Value.OrderByDescending(x => x.Index);
                foreach (var pokemon in a )
                {
                    Console.WriteLine($"{pokemon.Type} <-> {pokemon.Index}");
                }
            }

        }
    }
}
