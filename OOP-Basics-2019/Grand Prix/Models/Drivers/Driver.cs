public abstract class Driver : IDriver
{
    private const double BOX_INCREASE_TIME = 20;

    protected Driver(string name, ICar car)
    {
        this.Name = name;
        this.Car = car;
        this.TotalTime = 0;
        this.IsStopped = false;
    }

    public string Name { get; private set; }

    public double TotalTime { get; set; }

    public ICar Car { get; private set; }

    public double FuelConsumptionPerKm { get; protected set; }

    public double Speed => CalculateSpeed();

    public bool IsStopped { get; set; }

    public string FailureReason { get; set; }

    public void BoxChangeTyres(ITyre tyre)
    {
        this.Car.ChangeTyre(tyre);

        this.TotalTime += BOX_INCREASE_TIME;
    }

    public void BoxIncreaseFuel(double amount)
    {
        this.Car.IncreaseFuel(amount);

        this.TotalTime += BOX_INCREASE_TIME;
    }

    public virtual double CalculateSpeed()
    {
        var result = (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

        return result;
    }

    public void DegradateTyre()
    {
        this.Car.DegradateTyre();
    }

    public void IncreaseTotalTime(int trackLenght)
    {
        this.TotalTime += 60 / (trackLenght / this.Speed);
    }

    public void ReduceFuel(int trackLength)
    {
        var amount = trackLength * this.FuelConsumptionPerKm;

        this.Car.ReduceFuel(amount);
    }
}
