namespace _12.Google.Units
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.parents = new List<Parent>();
            this.children = new List<Child>();
            this.pokemons = new List<Pokemon>();
        }

        public string Name { get; private set; }

        public Company company { get; set; }

        public Car car { get; set; }

        public List<Parent> parents { get; set; }

        public List<Child> children { get; set; }

        public List<Pokemon> pokemons { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.Name);
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

            if (this.children.Count > 0)
            {
                this.children.ForEach(p => sb.AppendLine(p.ToString()));
            }

            return sb.ToString().TrimEnd();
        }
    }
}
