namespace DefiningClasses
{
    public class Tyre
    {
        public double TirePressure { get; private set; }
        public int TireAge { get; private set; }

        public Tyre(double tirePressure, int tireAge)
        {
            this.TirePressure = tirePressure;
            this.TireAge = tireAge;
        }
    }
}
