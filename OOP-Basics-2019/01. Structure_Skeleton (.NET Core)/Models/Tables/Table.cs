namespace SoftUniRestaurant.Models.Tables
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Contracts;
    using Drinks.Contracts;
    using Foods.Contracts;
    using Validators;

    public abstract class Table : ITable
    {
        private int capacity;
        private int numberOfPeople;
        private readonly List<IFood> foodOrders;
        private readonly List<IDrink> drinkOrders;

        protected Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            this.foodOrders = new List<IFood>();
            this.drinkOrders = new List<IDrink>();
            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
            this.IsReserved = false;
            this.numberOfPeople = 0;       
        }

        public IReadOnlyCollection<IFood> FoodOrders => this.foodOrders.AsReadOnly();

        public IReadOnlyCollection<IDrink> DrinkOrders => this.drinkOrders.AsReadOnly();

        public int TableNumber { get; private set; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                Validator.ValidateCapacity(value);

                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get
            {
                return this.numberOfPeople;
            }
            private set
            {
                Validator.ValidateNumberOfPeople(value);

                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson { get; private set; }

        public bool IsReserved { get; private set; }

        public decimal Price { get; private set; }

        public void Clear()
        {
            this.foodOrders.Clear();
            this.drinkOrders.Clear();
            this.numberOfPeople = 0;
            this.IsReserved = false;
        }

        public decimal GetBill()
        {
            var foodsBill = this.foodOrders.Sum(f => f.Price);

            var drinksBill = this.drinkOrders.Sum(d => d.Price);

            var personBill = this.PricePerPerson * this.NumberOfPeople;

            return foodsBill + drinksBill + personBill;
        }

        public string GetFreeTableInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson}");

            return sb.ToString().TrimEnd();
        }

        public string GetOccupiedTableInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Number of people: {this.NumberOfPeople}");

            GetOrderInfo("Food", sb, this.FoodOrders);

            GetOrderInfo("Drink", sb, this.DrinkOrders);

            return sb.ToString().TrimEnd();
        }

        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public void OrderFood(IFood food)
        {
            this.foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;
            this.IsReserved = true;
        }

        private void GetOrderInfo<T>(string name, StringBuilder sb, IReadOnlyCollection<T> orders)
        {
            var orderedCount = orders.Count;

            if (orderedCount == 0)
            {
                sb.AppendLine($"{name} orders: None");
            }
            else
            {
                sb.AppendLine($"{name} orders: {orderedCount}");

                foreach (var currentFood in orders)
                {
                    sb.AppendLine(currentFood.ToString());
                }
            }
        }

    }
}
