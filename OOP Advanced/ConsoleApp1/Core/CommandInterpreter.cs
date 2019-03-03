namespace ConsoleApp1.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Models.Appenders.Contracts;
    using Models.Appenders.Enums;
    using Models.Appenders.Factory;
    using Models.Layouts.Contracts;
    using Models.Layouts.Factory;
    using Models.Layouts.Factory.Contracts;


    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory; 

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }

        public void AddAppender(string[] args)
        {
            var appender = CreateAppender(args);

            appenders.Add(appender);
        }

        public void AddMessage(string[] args)
        {
            var reportLevel = Enum.Parse<ReportLevel>(args[0], true);
            var time = args[1];
            var message = args[2];

            foreach (var appender in appenders)
            {
                appender.Appends(time, reportLevel, message);
            }
        }

        public string AppendersInfo()
        {
            var sb = new StringBuilder();

            foreach (var appender in appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        private IAppender CreateAppender(string[] args)
        {
            var appenderType = args[0];
            var layout = CreateLayout(args[1]);

            var appender = this.appenderFactory.CreateAppender(appenderType, layout);

            if (args.Length > 2)
            {
                appender.ReportLevel = Enum.Parse<ReportLevel>(args[2], true);
            }
            return appender;
        }

        private ILayout CreateLayout(string type)
        {
            var layout = this.layoutFactory.CreateLayout(type);

            return layout;
        }
    }
}
