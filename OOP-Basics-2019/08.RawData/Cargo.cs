namespace DefiningClasses
{
    public class Cargo
    {
        public int CargoWeight { get; private set; }
        public string CargoType { get; private set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
    }
}
