namespace ConsoleApp1.Models.Appenders.Contracts
{
    using Enums;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        int AppendedMsgsCount { get; }

        void Appends(string dateTime, ReportLevel reportLevel, string message);
    }
}
