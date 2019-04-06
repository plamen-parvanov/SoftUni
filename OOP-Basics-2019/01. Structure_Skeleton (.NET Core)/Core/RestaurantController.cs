namespace SoftUniRestaurant.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Models.Drinks.Contracts;
    using Models.Drinks.Factories.Contracts;
    using Models.Foods.Contracts;
    using Models.Foods.Factories.Contracts;
    using Models.Tables.Contracts;
    using Models.Tables.Factories.Contracts;


    public class RestaurantController
    {
        private readonly List<IFood> menu;
        private readonly List<IDrink> drinks;
        private readonly List<ITable> tables;
        private readonly IFoodFactory foodFactory;
        private readonly IDrinkFactory drinkFactory;
        private readonly ITableFactory tableFactory;
        private decimal income;

        public RestaurantController(IFoodFactory foodFactory, IDrinkFactory drinkFactory,
            ITableFactory tableFactory)
        {
            this.menu = new List<IFood>();
            this.drinks = new List<IDrink>();
            this.tables = new List<ITable>();
            this.foodFactory = foodFactory;
            this.drinkFactory = drinkFactory;
            this.tableFactory = tableFactory;
        }

        public string AddFood(string type, string name, decimal price)
        {
            var currentFood = this.foodFactory.CreateFood(type, name, price);

            this.menu.Add(currentFood);

            var result = $"Added {name} ({type}) with price {price:f2} to the pool";

            return result;
        }

        public string AddDrink(string type, string name, int servingSize, string brand)
        {
            var currentDrink = this.drinkFactory.CreateDrink(type, name, servingSize, brand);

            this.drinks.Add(currentDrink);

            var result = $"Added {name} ({brand}) to the drink pool";

            return result;
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            var currentTable = this.tableFactory.CreateTable(type, tableNumber, capacity);

            this.tables.Add(currentTable);

            var result = $"Added table number {tableNumber} in the restaurant";

            return result;
        }

        public string ReserveTable(int numberOfPeople)
        {
            var suitableTable = this.tables
                                    .FirstOrDefault(t => !t.IsReserved && t.Capacity >= numberOfPeople);
            string result;

            if (suitableTable == null)
            {
                result = $"No available table for {numberOfPeople} people";
            }
            else
            {
                suitableTable.Reserve(numberOfPeople);

                result = $"Table {suitableTable.TableNumber} has been reserved for {numberOfPeople} people";
            }

            return result;
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var currentTable = GetTableFromNumber(tableNumber);

            var currentFood = GetFoodFromName(foodName);

            string result;

            if (currentTable == null)
            {
                result = $"Could not find table with {tableNumber}";
            }
            else if(foodName == null)
            {
                result = $"No {foodName} in the menu";
            }
            else
            {
                currentTable.OrderFood(currentFood);

                result = $"Table {tableNumber} ordered {foodName}";
            }

            return result;

        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var currentTable = GetTableFromNumber(tableNumber);

            var currentDrink = GetDrinkFromNameAndBrand(drinkName, drinkBrand);

            string result;

            if (currentTable == null)
            {
                result = $"Could not find table with {tableNumber}";
            }
            else if (currentDrink == null)
            {
                result = $"There is no {drinkName} {drinkBrand} available";
            }
            else
            {
                currentTable.OrderDrink(currentDrink);

                result = $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
            }

            return result;
        }

        public string LeaveTable(int tableNumber)
        {
            var currentTable = GetTableFromNumber(tableNumber);
            var currentBill = currentTable.GetBill();

            var result = $"Table: {tableNumber}" 
                         + Environment.NewLine 
                         + $"Bill: {currentBill}";

            this.income += currentBill;
            
            currentTable.Clear();

            return result;
        }

        public string GetFreeTablesInfo()
        {
            var freeTables = this.tables.Where(t => !t.IsReserved).ToList();

            var sb = new StringBuilder();

            freeTables.ForEach(t => sb.AppendLine(t.GetFreeTableInfo()));

            return sb.ToString().TrimEnd();
        }

        public string GetOccupiedTablesInfo()
        {
            var reservedTables = this.tables.Where(t => t.IsReserved).ToList();

            var sb = new StringBuilder();

            reservedTables.ForEach(t => sb.AppendLine(t.GetOccupiedTableInfo()));

            return sb.ToString().TrimEnd();
        }

        public string GetSummary()
        {
            return $"Total income: {this.income:f2}lv";
        }

        private ITable GetTableFromNumber(int tableNumber)
        {
            return this.tables.FirstOrDefault(t => t.TableNumber == tableNumber);
        }

        private IFood GetFoodFromName(string foodName)
        {
            return this.menu.FirstOrDefault(f => f.Name == foodName);
        }

        private IDrink GetDrinkFromNameAndBrand(string drinkName, string drinkBrand)
        {
            return this.drinks.FirstOrDefault(d => d.Name == drinkName && d.Brand == drinkBrand);
        }
    }
}
