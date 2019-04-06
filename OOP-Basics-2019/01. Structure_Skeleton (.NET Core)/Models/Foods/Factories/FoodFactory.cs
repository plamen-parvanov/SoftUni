namespace SoftUniRestaurant.Models.Foods.Factories
{
    using System.Reflection;
    using System.Linq;
    using System;

    using Contracts;
    using Foods.Contracts;

    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string typeName, string name, decimal price)
        {
            var type = Assembly.GetExecutingAssembly()
                               .GetTypes()
                               .FirstOrDefault(t => t.Name == typeName);

            try
            {
                var instance = (IFood)Activator.CreateInstance(type, new object[] { name, price });

                return instance;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.InnerException.Message);
            }
        }
    }
}
