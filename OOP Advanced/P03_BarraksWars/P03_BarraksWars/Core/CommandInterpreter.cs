namespace _03BarracksFactory.Core
{
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private ICommandFactory commandFactory;

        public CommandInterpreter(ICommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var command = this.commandFactory.CreateCommand(data, commandName);

            return command;
        }
    }
}
