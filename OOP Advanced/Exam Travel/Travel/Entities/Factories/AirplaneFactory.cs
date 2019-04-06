namespace Travel.Entities.Factories
{
    using System.Reflection;
    using System.Linq;

    using Contracts;
	using Airplanes.Contracts;
    using System;

    public class AirplaneFactory : IAirplaneFactory
	{
        public IAirplane CreateAirplane(string typeName)
        {
            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.ToLower() == typeName.ToLower());

            var instance = (IAirplane)Activator.CreateInstance(type);
            return instance;
        }
	}
}