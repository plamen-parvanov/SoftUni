public class Pokemon
{
    private string evolutionType;
    private int evolutionIndex;

    public Pokemon(string evolutionType, int evolutionIndex)
    {
        this.EvolutionType = evolutionType;
        this.EvolutionIndex = evolutionIndex;
    }

    public string EvolutionType
    {
        get { return this.evolutionType; }

        private set { this.evolutionType = value; }

    }
    public int EvolutionIndex
    {
        get { return this.evolutionIndex; }

        private set { this.evolutionIndex = value; }
    }
}
