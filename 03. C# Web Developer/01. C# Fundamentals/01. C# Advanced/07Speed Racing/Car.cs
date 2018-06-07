public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKm;
    private double distanceTraveled;

    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public bool CanMoveThatDistance(double amountOfKm)
    {
        var consumption = amountOfKm * this.fuelConsumptionPerKm;
        return fuelAmount - consumption >= 0;
    }

    public void MovingTheCar(double amountOfKm)
    {
        this.fuelAmount -= amountOfKm * this.fuelConsumptionPerKm;
        this.distanceTraveled += amountOfKm;
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:F2} {this.distanceTraveled}";
    }
}
