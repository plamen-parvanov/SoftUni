using _01.Vehicles.ErrorMessages;
using System;

namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double INCREASE_CONSUMPTION = 1.6;
        private const double MAX_TANK_CAPACITY = 0.95; 

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm + INCREASE_CONSUMPTION, tankCapacity)
        {
        }

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException(ErrorMessage.NegativeFuelAmount);
            }
            else if (fuel + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessage.OverTankAmount, fuel));
            }

            this.FuelQuantity += fuel * MAX_TANK_CAPACITY;
        }
    }
}
