namespace SoftUniRestaurant.Models.Drinks.Factories.Contracts
{
    using Drinks.Contracts;

    public interface IDrinkFactory
    {
        IDrink CreateDrink(string typeName, string name, int servingSize, string brand);
    }
}
