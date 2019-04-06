namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var type = Assembly.GetExecutingAssembly()
                                .GetTypes()
                                .First(t => t.Name == unitType);

            // if(type == null)   i   dali instance e IUnit 

            var instance = (IUnit)Activator.CreateInstance(type);

            return instance;
        }
    }
}
