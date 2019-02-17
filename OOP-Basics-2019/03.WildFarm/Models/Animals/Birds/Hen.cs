namespace _03.WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightModifier => 0.35;

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
