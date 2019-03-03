namespace ConsoleApp1.Models.Appenders.Factory
{
    using System;

    using ConsoleApp1.Models.Appenders.Contracts;
    using ConsoleApp1.Models.Layouts.Contracts;
    using ConsoleApp1.Models.Loggers;

    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            IAppender appender;
            switch (type)
            {
                case "ConsoleAppender":
                    appender = new ConsoleAppender(layout);
                    break;
                case "FileAppender":
                    appender = new FileAppender(layout, new LogFile());
                    break;
                default:
                    throw new ArgumentException("Invalid Appender Type");
            }

            return appender;
        }
    }
}
