namespace ConsoleApp1.Models.Layouts
{
    using Contracts;
    using System.Text;

    class XmlLayout : ILayout
    {
        public string Format => CreateFormat();

        private string CreateFormat()
        {
            var sb = new StringBuilder();

            sb.AppendLine("<log>");
            sb.AppendLine("   <date>{0}</date>");
            sb.AppendLine("   <level>{1}</level>");
            sb.AppendLine("   <message>{2}</message>");
            sb.AppendLine("</log>");

            return sb.ToString().TrimEnd();
        }
    }
}
