public class DriverFactory
{
    public IDriver CreateDriver(string type, string name, ICar car)
    {
        IDriver driver;

        switch (type )
        {
            case "Aggressive":
                driver = new AggressiveDriver(name, car);
                break;
            case "Endurance":
                driver = new EnduranceDriver(name, car);
                break;
            default:
                throw new System.ArgumentException();
        }

        return driver;
    }
}
