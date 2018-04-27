public class Cat
{
    private string name;
    private int age;
    private int intelligenceQuotient;

    public Cat(string name, int age, int intelligenceQuotient)
    {
        this.name = name;
        this.age = age;
        this.intelligenceQuotient = intelligenceQuotient; 
    }

    public void ProduceSound()
    {
        System.Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
    }

    public string Name
    {
        get { return this.name; }
    }
    public int Age
    {
        get { return this.age; }
    }
    public int IntelligenceQuotient
    {
        get { return this.intelligenceQuotient; }
    }
}

