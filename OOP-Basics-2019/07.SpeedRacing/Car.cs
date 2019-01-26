namespace DefiningClasses
{
    public class Car
    {
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private int distance;

        public string Model { get; private set; }

        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.Model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            this.distance = 0;
        }

        public bool CanMove(int amountOfKm)
        {
            var consumption = amountOfKm * this.fuelConsumption;

            if (fuelAmount >= consumption)
            {
                this.fuelAmount -= consumption;
                this.distance += amountOfKm;

                return true;
            }

            return false;
        }

        public override string ToString()
        {
            var result = $"{this.Model} {this.fuelAmount:F2} {this.distance}";

            return result;
        }
    }
}
