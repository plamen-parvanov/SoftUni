using System;

namespace _04.ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                CheckValidName(value, nameof(this.Name));

                this.name = value;
            }
        }

        public double Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0 )
                {
                    throw new ArgumentException(Errors.ErrorMessage.InvalidMoney);
                }

                this.cost = value;
            }
        }
       
        private void CheckValidName(string value, string name)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(
                    string.Format(Errors.ErrorMessage.InvalidName, name));
            }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
