
namespace ConsoleApp1.Models.Appenders
{
    using Contracts;
    using Enums;
    using Layouts.Contracts;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = 0;
            this.AppendedMsgsCount = 0;
        }
        public ReportLevel ReportLevel { get; set; }

        public int AppendedMsgsCount { get; protected set; }

        protected ILayout Layout { get; }

        public abstract void Appends(string dateTime, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return "Appender type: {0}, Layout type: {1}, Report level: {2}, Messages appended: {3}";
        }
    }
}
