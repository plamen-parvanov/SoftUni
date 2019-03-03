namespace ConsoleApp1.Core.Contracts
{
    public interface ICommandInterpreter
    {
        void AddAppender(string[] args);

        void AddMessage(string[] args);
    }
}
