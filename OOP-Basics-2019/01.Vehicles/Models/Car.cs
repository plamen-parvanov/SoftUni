namespace _01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double INCREASED_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm + INCREASED_CONSUMPTION, tankCapacity)
        {
        }
    }
}
