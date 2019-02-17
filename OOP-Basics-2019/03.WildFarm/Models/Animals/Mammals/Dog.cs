namespace _03.WildFarm.Models.Animals.Mammals
{
    using _03.WildFarm.Models.Foods;
    using _03.WildFarm.Validators;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightModifier => 0.4;

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override void FeedAnimal(Food food)
        {
            Validator.FoodEaten(this.GetType().Name, food.Name, "Meat");

            base.FeedAnimal(food);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
