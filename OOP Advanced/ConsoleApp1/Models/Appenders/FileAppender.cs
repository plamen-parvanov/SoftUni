namespace ConsoleApp1.Models.Appenders
{
    using System.IO;

    using Enums;
    using Layouts.Contracts;
    using Loggers.Contracts;

    public class FileAppender : Appender
    {
        private const string PATH = "log.txt";

        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile) 
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Appends(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                var msgInfo = string.Format(this.Layout.Format, dateTime,
                    reportLevel, message);

                this.logFile.Write(msgInfo);

                File.AppendAllText(PATH, msgInfo + System.Environment.NewLine);

                this.AppendedMsgsCount++;
            }
           
        }

        public override string ToString()
        {
            var result = string.Format("{0}, File size: {1}", 
                string.Format(base.ToString(),
                     this.GetType().Name, this.Layout.GetType().Name,
                     this.ReportLevel.ToString().ToUpper(),
                     this.AppendedMsgsCount), 
                this.logFile.Size);

            return result;
        }
    }
}
