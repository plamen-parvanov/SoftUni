using System;
using System.Collections.Generic;
using System.Text;

namespace _04.ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person(string name, double money)
        {
            this.bag = new List<Product>();
            this.Name = name;
            this.Money = money; 
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

        public double Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                CheckValidMoney(value);

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag => this.bag;

        public string TryToBuy(Product product)
        {
            if (this.money >= product.Cost)
            {
                this.AddProductInBag(product);

                return ($"{this.name} bought {product.Name}");
            }
            
                return ($"{this.name} can't afford {product.Name}");
        }

        public void AddProductInBag(Product product)
        {
            this.bag.Add(product);

            this.money -= product.Cost;
        }

        private void CheckValidMoney(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                string.Format(Errors.ErrorMessage.InvalidMoney));
            }
        }

        private void CheckValidName(string value, string name)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                string.Format(Errors.ErrorMessage.InvalidName, name));
            }
        }

        public override string ToString()
        {
            if (this.bag.Count == 0)
            {
                return $"{this.name} - Nothing bought";
            }

             return $"{this.name} - " + string.Join(", ", this.bag);  
        }

    }
}
