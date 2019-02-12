namespace _05.PizzaCalories.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using _05.PizzaCalories.Errors;

    public class Pizza
    {
        private const int NAME_MAX_SYMBOLS = 15;
        private const int MAX_TOPPINGS_COUNT = 10;

        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.toppings = new List<Topping>();
            this.Name = name;
            this.dough = dough;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > NAME_MAX_SYMBOLS)
                {
                    throw new ArgumentException(
                        string.Format(ErrorMessage.InvalidPizzaName, nameof(this.name),
                        NAME_MAX_SYMBOLS));
                }
                this.name = value;
            }
        }

        public void AddTopping(Topping toping)
        {
            if (this.toppings.Count > MAX_TOPPINGS_COUNT)
            {
                throw new ArgumentException(
                    string.Format(ErrorMessage.IvalidNumberOfToppings,
                    nameof(this.toppings), MAX_TOPPINGS_COUNT));
            }

            this.toppings.Add(toping);
        }

        public int NumberOfToppings => this.toppings.Count;

        public double TotalCalories => this.toppings.Sum(t => t.Caloeries) + this.dough.Calories;
      
    }
}
