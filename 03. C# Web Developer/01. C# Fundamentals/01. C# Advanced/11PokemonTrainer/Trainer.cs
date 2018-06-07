using System.Collections.Generic;

public class Trainer
{
    public string name;
    public int badges;
    public List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.name = name;
        this.badges = 0;
        this.pokemons = new List<Pokemon>();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }

    public override string ToString()
    {
        return $"{name} {badges} {pokemons.Count}";
    }
}
