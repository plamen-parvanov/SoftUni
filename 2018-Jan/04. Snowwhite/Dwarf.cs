public class Dwarf
{
    private string name;
    private string color;
    private int physics;

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }
    public string Color
    {
        get { return this.color; }
        private set { this.color = value; }
    }
    public int Physics
    {
        get { return this.physics; }
        private set { this.physics = value; }
    }

    public Dwarf(string name,string color, int physics)
    {
        this.Name = name;
        this.Color = color;
        this.Physics = physics; 
    }
}
