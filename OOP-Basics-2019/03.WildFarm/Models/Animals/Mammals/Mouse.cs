namespace _03.WildFarm.Models.Animals.Mammals
{
    using Foods;
    using Validators;

    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightModifier => 0.1;

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void FeedAnimal(Food food)
        {
            Validator.FoodEaten(this.GetType().Name, food.Name, "Vegetable", "Fruit");

            base.FeedAnimal(food);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
