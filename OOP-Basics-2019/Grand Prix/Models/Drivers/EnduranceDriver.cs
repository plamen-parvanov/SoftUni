public class EnduranceDriver : Driver
{
    private const double ENDURANCE_FUEL_CONSUMPTION = 1.5;

    public EnduranceDriver(string name, ICar car) : base(name, car)
    {
        this.FuelConsumptionPerKm = ENDURANCE_FUEL_CONSUMPTION;
    }
}
