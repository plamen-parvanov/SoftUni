namespace ConsoleApp1.Models.Loggers
{
    using Appenders.Contracts;
    using Appenders.Enums;
    using Contracts;
    using System.Collections.Generic;

    public class Logger : ILogger
    {
        private readonly IList<IAppender> appenders;

        public Logger()
        {
            this.appenders = new List<IAppender>();
        }

        public Logger(IAppender iAppender) : this()
        {
            this.appenders.Add(iAppender);
        }

        public Logger(IAppender firstAppender, IAppender secondAppender) 
            : this(firstAppender)
        {
            this.appenders.Add(secondAppender);
        }

        public Logger(IAppender firstAppender, IAppender secondAppender, IAppender thirdAppender)
           : this(firstAppender, secondAppender)
        {
            this.appenders.Add(thirdAppender);
        }

        public void Info(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.INFO, message);
        }

        public void Warning(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.WARNING, message);
        }

        public void Error(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.ERROR, message);
        }

        public void Critical(string dateTime, string message)
        {
            AppendMessage(dateTime, ReportLevel.CRITICAL, message);
        }

        public void Fatal(string dateTime, string message)
        {
            AppendMessage(dateTime,ReportLevel.FATAL, message);
        }

        private void AppendMessage(string dateTime, ReportLevel reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Appends(dateTime, reportLevel, message);
            }
        }
    }
}
