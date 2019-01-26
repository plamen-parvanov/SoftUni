namespace _11.PokemonTrainer.Units
{
    public class Pokemon
    {
        private string name;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.Element = element;
            this.Health = health;
        }

        public string Element { get; private set; }

        public int Health { get; set; }
    }
}
