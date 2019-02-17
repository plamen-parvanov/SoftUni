namespace _01.Vehicles.Factories
{
    using Models;

    public static class CarFactory
    {
        public static Car CraeteCar(double fuelQuantity, 
            double fuelConsumptionPerKm, double tankCapacity)
        {
            return new Car(fuelQuantity, fuelConsumptionPerKm, tankCapacity);
        }
    }
}
