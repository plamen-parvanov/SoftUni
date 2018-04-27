public class Dog
{
    private string name;
    private int age;
    private int numberOfLegs;

    public Dog(string name, int age, int numberOfLegs)
    {
        this.name = name;
        this.age = age;
        this.numberOfLegs = numberOfLegs;
    }

    public void ProduceSound()
    {
        System.Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
    }

    public string Name
    {
        get { return this.name; }
    }
    public int Age
    {
        get { return this.age; }
    } 
    public int NumberOfLegs
    {
        get { return this.numberOfLegs; }
    }
}

