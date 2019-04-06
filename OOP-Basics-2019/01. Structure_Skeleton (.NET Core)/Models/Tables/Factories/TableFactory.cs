namespace SoftUniRestaurant.Models.Tables.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using Tables.Contracts;

    public class TableFactory : ITableFactory
    {
        public ITable CreateTable(string typeName, int tableNumber, int capacity)
        {
            var type = Assembly.GetExecutingAssembly()
                               .GetTypes()
                               .FirstOrDefault(t => t.Name == typeName + "Table");

            try
            {
                var instance = (ITable)Activator.CreateInstance(type, new object[] { tableNumber, capacity });

                return instance;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.InnerException.Message);
            }
        }
    }
}
