namespace SoftUniRestaurant.Models.Foods.Factories.Contracts
{
    using Foods.Contracts;

    public interface IFoodFactory
    {
        IFood CreateFood(string typeName, string name, decimal price);
    }
}
