namespace _03.WildFarm.Models.Animals.Mammals.Felines
{
    using Foods;
    using Validators;

    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightModifier => 0.3;

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override void FeedAnimal(Food food)
        {
            Validator.FoodEaten(this.GetType().Name, food.Name, "Vegetable", "Meat");

            base.FeedAnimal(food);
        }
    }
}
