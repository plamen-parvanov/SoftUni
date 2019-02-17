namespace _03.WildFarm.Models.Animals
{
    using Foods;

    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; } = 0;

        public abstract double WeightModifier { get; }

        public abstract string ProduceSound();

        public virtual void FeedAnimal(Food food)
        {
            this.Weight += food.Quantity * this.WeightModifier;
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
