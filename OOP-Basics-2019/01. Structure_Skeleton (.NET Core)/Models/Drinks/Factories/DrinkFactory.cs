namespace SoftUniRestaurant.Models.Drinks.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using Drinks.Contracts;

    public class DrinkFactory : IDrinkFactory
    {
        public IDrink CreateDrink(string typeName, string name, int servingSize, string brand)
        {
            var type = Assembly.GetExecutingAssembly()
                               .GetTypes()
                               .FirstOrDefault(t => t.Name == typeName);

            try
            {
                var instance = (IDrink)Activator.CreateInstance(type, new object[] { name, servingSize, brand });

                return instance;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.InnerException.Message);
            }
        }
    }
}
