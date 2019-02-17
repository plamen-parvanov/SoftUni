namespace _03.WildFarm.Models.Animals.Birds
{
    using Foods;
    using Validators;

    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double WeightModifier => 0.25;

        public override void FeedAnimal(Food food)
        {
            Validator.FoodEaten(this.GetType().Name, food.Name, "Meat");

            base.FeedAnimal(food);
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
