using System.Collections.Generic;

namespace _11.PokemonTrainer.Units
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; private set; }

        public int Badges { get; private set; }

        public List<Pokemon> Pokemons { get; }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void RemovePokemonsWithNoHealth()
        {
            this.Pokemons.RemoveAll(p => p.Health <= 0);
        }

        public void IncreaseBagdges()
        {
            this.Badges++;
        }

        public override string ToString()
        {
            var result = $"{this.Name} {this.Badges} {this.Pokemons.Count}";

            return result;
        }
    }
}
