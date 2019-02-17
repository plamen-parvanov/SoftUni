namespace _01.Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double INCREASED_CONSUMPTION = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm + INCREASED_CONSUMPTION, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumptionPerKM -= INCREASED_CONSUMPTION;

            return base.Drive(distance);
        }
    }
}
