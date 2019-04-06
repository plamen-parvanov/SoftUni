namespace Travel.Entities.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
	using Items.Contracts; 

    public class ItemFactory : IItemFactory
	{
		public IItem CreateItem(string typeName)
		{
            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == typeName.ToLower());

            var instance = (IItem)Activator.CreateInstance(type);
            return instance;
		}
	}
}
