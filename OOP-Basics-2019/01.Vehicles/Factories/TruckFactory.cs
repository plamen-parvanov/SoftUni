namespace _01.Vehicles.Factories
{
    using Models;

    public static class TruckFactory
    {
        public static Truck CraeteTruck(double fuelQuantity,
            double fuelConsumptionPerKm, double tankCapacity)
        {
            return new Truck(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
        }
    }
}
