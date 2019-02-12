namespace _05.PizzaCalories.Models
{
    using System;
    using _05.PizzaCalories.Enums;
    using _05.PizzaCalories.Errors;

    public class Topping
    {
        private const int CALORIES_PER_GRAM = 2;
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 50;

        private ToppingType topitnType;
        private int weight;

        public Topping(string toppingType, int weight)
        {
            SetType(toppingType);

            SetWeight(weight);
        }

        public double Caloeries
        {
            get
            {
                var typeModifier = (int)this.topitnType / 10d;

                return CALORIES_PER_GRAM * this.weight * typeModifier;
            }
        }

        private void SetType(string input)
        {
            try
            {
                this.topitnType = Enum.Parse<ToppingType>(input, true);
            }
            catch (Exception)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessage.InvalidToppingType, input));
            }
        }

        private void SetWeight(int value)
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessage.InvalidToppingWeight, topitnType,
                    nameof(this.weight), MIN_WEIGHT, MAX_WEIGHT));
            }

            this.weight = value;
        }
    }
}
