namespace ConsoleApp1.Models.Loggers
{
    using System.Text;
    using System.Linq;
    using Contracts;

    public class LogFile : ILogFile
    {       
        private StringBuilder sb;

        public LogFile()
        {
            this.sb = new StringBuilder();
        }

        public int Size => this.sb.ToString().Where(c => char.IsLetter(c)).Sum(c => c);

        public void Write(string messageInfo)
        {
            this.sb.AppendLine(messageInfo);
        }
    }
}
