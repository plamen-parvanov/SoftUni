using System;

public class Car : ICar
{
    private const double MAXIMUM_FUEL_CAPACITY = 160;

    private double fuelAmount;

    public Car(int hp, double fuelAmount, ITyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public int Hp { get; private set; }

    public double FuelAmount
    {
        get
        {
            return this.fuelAmount;
        }
        private set
        {
            if (value > MAXIMUM_FUEL_CAPACITY)
            {
                value = MAXIMUM_FUEL_CAPACITY;
            }

            if (value < 0)
            {
                throw new OutOfFuelException();
            }

            this.fuelAmount = value;
        }
    }

    public ITyre Tyre { get; private set; }

    public void ChangeTyre(ITyre tyre)
    {
        this.Tyre = tyre;
    }

    public void DegradateTyre()
    {
        this.Tyre.ReduceDegradation();
    }

    public void IncreaseFuel(double amount)
    {
        this.FuelAmount += amount;
    }

    public void ReduceFuel(double amount)
    {
        this.FuelAmount -= amount;
    }
}
