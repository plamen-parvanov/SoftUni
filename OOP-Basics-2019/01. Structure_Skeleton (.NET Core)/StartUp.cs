namespace SoftUniRestaurant
{
    using Core;
    using SoftUniRestaurant.Models.Drinks.Factories;
    using SoftUniRestaurant.Models.Drinks.Factories.Contracts;
    using SoftUniRestaurant.Models.Foods.Factories;
    using SoftUniRestaurant.Models.Foods.Factories.Contracts;
    using SoftUniRestaurant.Models.Tables.Factories;
    using SoftUniRestaurant.Models.Tables.Factories.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IFoodFactory foodFactory = new FoodFactory();
            IDrinkFactory drinkFactory = new DrinkFactory();
            ITableFactory tableFactory = new TableFactory();
            var restaurantController = new RestaurantController(foodFactory, 
                drinkFactory, tableFactory);
            var engine = new Engine(restaurantController);
            engine.Run();
        }
    }
}
