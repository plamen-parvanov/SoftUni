using System;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; private set; }

        public Engine Engine { get; private set; }

        public Cargo Cargo { get; private set; }

        public Tyre[] Tires { get; private set; } = new Tyre[4];

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight,
                   string cargoType, double tire1Pressure, int tire1Age, 
                   double tire2Pressure, int tire2Age, double tire3Pressure,
                   int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);

            CreateTires(tire1Pressure, tire1Age,tire2Pressure, tire2Age,
                tire3Pressure, tire3Age, tire4Pressure, tire4Age);

        }

        private void CreateTires(double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Tires[0] = new Tyre(tire1Pressure, tire1Age);
            Tires[1] = new Tyre(tire2Pressure, tire2Age);
            Tires[2] = new Tyre(tire3Pressure, tire3Age);
            Tires[3] = new Tyre(tire4Pressure, tire4Age);
        }
    }
}
