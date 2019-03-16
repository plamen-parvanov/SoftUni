public class AggressiveDriver : Driver

{
    private const double AGGRESSIVE_FUEL_CONSUMPTION = 2.7;
    private const double AGGRESSIVE_SPEED_MULTIPLIER = 1.3;

    public AggressiveDriver(string name, ICar car) : base(name, car)
    {
        this.FuelConsumptionPerKm = AGGRESSIVE_FUEL_CONSUMPTION;
    }

    public override double CalculateSpeed()
    {
        return base.CalculateSpeed() * AGGRESSIVE_SPEED_MULTIPLIER;
    }
}
