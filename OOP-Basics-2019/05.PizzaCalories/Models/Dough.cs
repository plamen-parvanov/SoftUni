namespace _05.PizzaCalories.Models
{
    using System;
    using _05.PizzaCalories.Enums;
    using _05.PizzaCalories.Errors;

    public class Dough
    {
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 200;
        private const int CALOEIRES_PER_GRAM = 2;

        private FlourType flourType;
        private BakingTechnique bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTchnique, int weight)
        {
            SetEnum("flourType", flourType);

            SetEnum("bakingTechnique", bakingTchnique);

            SetWeight(weight);
        }

        private void SetWeight(int value)
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessage.InvalidDoughtWeight,
                    nameof(weight), MIN_WEIGHT, MAX_WEIGHT));
            }

            this.weight = value;
        }

        private void SetEnum(string enumType, string type)
        {
            try
            {
                if (enumType == "flourType")
                {
                    this.flourType = Enum.Parse<FlourType>(type, true);
                }
                else
                {
                    this.bakingTechnique = Enum.Parse<BakingTechnique>(type, true);
                }
            }
            catch (Exception)
            {
                throw new ArgumentException(ErrorMessage.InvalidDoughtType);
            }                 
        }

        public double Calories
        {
            get
            {
                var flourModifier = (int)this.flourType / 10d;
                var bakingModifier = (int)this.bakingTechnique / 10d;

                return CALOEIRES_PER_GRAM * this.weight * flourModifier * bakingModifier;
            }
        }
    }
}
