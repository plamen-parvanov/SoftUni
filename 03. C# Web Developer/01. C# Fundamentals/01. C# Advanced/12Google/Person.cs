using System.Collections.Generic;
using System.Text;

public class Person
{
    public string name;
    public Company company;
    public Car car;
    public List<Pokemon> pokemons;
    public List<Parent> parents;
    public List<Children> childrens;

    public Person(string name)
    {
        this.name = name;
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parent>();
        this.childrens = new List<Children>();
    }

    public void AddCompany(Company company)
    {
        this.company = company;
    }

    public void AddCar(Car car)
    {
        this.car = car;
    }

    public void AddParent(Parent parent)
    {
        this.parents.Add(parent);
    }

    public void AddChild(Children children)
    {
        this.childrens.Add(children);
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(this.name);

        sb.AppendLine("Company:");
        if (this.company != null)
        {
            sb.AppendLine(this.company.ToString());
        }

        sb.AppendLine("Car:");
        if (this.car != null)
        {
            sb.AppendLine(this.car.ToString());
        }

        sb.AppendLine("Pokemon:");
        if (this.pokemons.Count > 0)
        {
            this.pokemons.ForEach(p => sb.AppendLine(p.ToString()));
        }

        sb.AppendLine("Parents:");
        if (this.parents.Count > 0)
        {
            this.parents.ForEach(p => sb.AppendLine(p.ToString()));
        }

        sb.AppendLine("Children:");
        if (this.childrens.Count > 0)
        {
            this.childrens.ForEach(p => sb.AppendLine(p.ToString()));
        }


        return sb.ToString();
    }
}
