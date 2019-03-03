namespace ConsoleApp1.Models.Loggers.Contracts
{
    public interface ILogFile
    {
        int Size { get; }

        void Write(string messageInfo);
    }
}
