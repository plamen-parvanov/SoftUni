using _01.Vehicles.ErrorMessages;
using System;

namespace _01.Vehicles.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm,
            double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKM = fuelConsumptionPerKm;
        }

        public double TankCapacity { get; private set; }

        public double FuelConsumptionPerKM { get; protected set; }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ErrorMessage.NegativeFuelAmount);
                }
                else if (value > this.TankCapacity)
                {
                    value = 0;
                }

                this.fuelQuantity = value;
            }
        }

        public string Drive(double distance)
        {
            var fuelNeeded = distance * this.FuelConsumptionPerKM;

            if (this.FuelQuantity >= fuelNeeded)
            {
                this.FuelQuantity -= fuelNeeded;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
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

            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
