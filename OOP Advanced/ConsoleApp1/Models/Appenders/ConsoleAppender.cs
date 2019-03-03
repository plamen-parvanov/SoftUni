namespace ConsoleApp1.Models.Appenders
{
    using System;

    using Enums;
    using Layouts.Contracts;   

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }
      
        public override void Appends(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                Console.WriteLine(string.Format(this.Layout.Format, 
                    dateTime, reportLevel, message));

                this.AppendedMsgsCount++;
            }
        }

        public override string ToString()
        {
            var result = string.Format(base.ToString(), this.GetType().Name,
             this.Layout.GetType().Name, this.ReportLevel.ToString().ToUpper(),
             this.AppendedMsgsCount);

            return result;
        }
    }
}
