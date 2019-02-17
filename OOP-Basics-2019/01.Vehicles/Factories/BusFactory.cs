namespace _01.Vehicles.Factories
{
    using Models;

    public static class BusFactory
    {
        public static Bus CraeteBus(double fuelQuantity,
            double fuelConsumptionPerKm, double tankCapacity)
        {
            return new Bus(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
        }
    }
}
