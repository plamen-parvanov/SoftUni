public class Snake
{
    private string name;
    private int age;
    private int crueltyCoefficient;

    public Snake(string name, int age, int crueltyCoefficient)
    {
        this.name = name;
        this.age = age;
        this.crueltyCoefficient = crueltyCoefficient;
    }

    public void ProduceSound()
    {
        System.Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
    }

    public string Name
    {
        get { return this.name; }
    }
    public int Age
    {
        get { return this.age; }
    }
    public int CrueltyCoefficient
    {
        get { return this.crueltyCoefficient; }
    }
}

