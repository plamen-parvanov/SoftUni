namespace _03.WildFarm.Models.Animals.Mammals.Felines
{
    using Foods;
    using Validators;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightModifier => 1;

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }

        public override void FeedAnimal(Food food)
        {
            Validator.FoodEaten(this.GetType().Name, food.Name, "Meat");

            base.FeedAnimal(food);
        }
    }
}
