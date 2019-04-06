namespace SoftUniRestaurant.Models.Foods
{
    using Contracts;
    using SoftUniRestaurant.Validators;

    public abstract class Food : IFood
    {
        private string name;
        private int servingSize;
        private decimal price;

        protected Food(string name, int servingSize, decimal price)
        {
            this.Name = name;
            this.ServingSize = servingSize;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.ValidateName(value);

                this.name = value;
            }
        }

        public int ServingSize
        {
            get
            {
                return this.servingSize;
            }
            private set
            {
                Validator.ValidateServingSize(value);

                this.servingSize = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                Validator.ValidatePriceFood(value);

                this.price = value;
            }
        }

        public override string ToString()
        {
            return "{0}: {1}g - {2:F2}";
        }
    }
}
