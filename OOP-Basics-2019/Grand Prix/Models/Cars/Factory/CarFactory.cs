public class CarFactory
{
    public ICar CreteCar(int hp, double fuelAmount, ITyre tyre)
    {
        ICar car = new Car(hp, fuelAmount, tyre);

        return car;
    }
}
