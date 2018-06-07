public class Car
{
    public string carModel;
    public int carSpeed;

    public Car(string carModel, int carSpeed)
    {
        this.carModel = carModel;
        this.carSpeed = carSpeed;
    }

    public override string ToString()
    {
        return $"{this.carModel} {this.carSpeed}";
    }
}