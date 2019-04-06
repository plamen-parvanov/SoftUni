namespace _03BarracksFactory.Contracts
{
    public interface ICommandFactory
    {
        IExecutable CreateCommand(string[] data, string commandName); 
    }
}
