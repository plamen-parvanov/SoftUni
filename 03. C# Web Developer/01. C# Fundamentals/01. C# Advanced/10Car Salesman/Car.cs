public class Car
{
    public string model;
    public Engine engine;
    public string weight;
    public string color;

    public Car(string model, Engine engine, string weight, string color)
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }

    public override string ToString()
    {
        return ""; 
    }
}
