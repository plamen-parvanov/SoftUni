namespace SoftUniRestaurant.Models.Drinks
{
    using Contracts;
    using SoftUniRestaurant.Validators;

    public abstract class Drink : IDrink
    {
        private string name;
        private int servingSize;
        private decimal price;
        private string brand;

        protected Drink(string name, int servingSize, decimal price, string brand)
        {
            this.Name = name;
            this.ServingSize = servingSize;
            this.Price = price;
            this.Brand = brand;
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
                Validator.ValidatePriceDrink(value);

                this.price = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            private set
            {
                Validator.ValidateBrand(value);

                this.brand = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}ml - {3:F2}lv", this.Name, this.Brand,
                                                  this.ServingSize, this.Price);
        }
    }
}
