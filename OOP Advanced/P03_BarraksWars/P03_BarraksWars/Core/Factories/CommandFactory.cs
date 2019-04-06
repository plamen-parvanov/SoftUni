namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Commands;
    using Contracts;

    public class CommandFactory: ICommandFactory
    {
        private IServiceProvider serviceProvider;

        public CommandFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IExecutable CreateCommand(string[] data, string commandName)
        {
            var type = Assembly.GetExecutingAssembly()
                               .GetTypes()
                               .First(t => t.Name.ToLower() == commandName + "command");

            if (type == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            var injectFields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                   .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectAttribute)))
                                   .ToArray();

            var injectArgs = injectFields.Select(x => this.serviceProvider.GetService(x.FieldType))
                                         .ToArray();

            // dali moje da se castne kum IExecutable
            var instance = (IExecutable)Activator.CreateInstance(type, 
                           new object[] { data}.Concat(injectArgs).ToArray());

            return instance;
        }
    }
}
