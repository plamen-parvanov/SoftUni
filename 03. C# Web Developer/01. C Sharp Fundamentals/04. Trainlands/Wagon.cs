public class Wagon
{
    private string name;
    private int power;

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }
    public int Power
    {
        get { return this.power; }
        private set { this.power = value; }
    }

    public Wagon(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }
}
