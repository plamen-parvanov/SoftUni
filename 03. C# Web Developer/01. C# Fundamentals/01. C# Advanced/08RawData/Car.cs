using System.Collections.Generic;

public class Car
{
    public string model;
    public Engine engine;
    public Cargo cargo;
    public List<Tire> tires;

    public Car(string model, int engineSpeed, int enginePower, int cargoWeight,
        string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure,
        int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, 
        int tire4Age)
    {
        this.model = model;
        this.engine = new Engine(engineSpeed, enginePower);
        this.cargo = new Cargo(cargoWeight, cargoType);
        this.tires = new List<Tire>(4);
        this.tires.Add(new Tire(tire1Pressure, tire1Age));
        this.tires.Add(new Tire(tire2Pressure, tire2Age));
        this.tires.Add(new Tire(tire3Pressure, tire3Age));
        this.tires.Add(new Tire(tire4Pressure, tire4Age));

    }
}