namespace _04.Telephony
{
    using _04.Telephony.Contracts;
    using System.Linq;
    using System.Text;

    public class Smartphone : ICallable, IBrowseable
    {
        private string[] calls;
        private string[] sites;

        public Smartphone(string[] calls, string[] sites)
        {
            this.calls = calls;
            this.sites = sites;
        }

        public string Browsing()
        {
            var sb = new StringBuilder();

            foreach (var site in this.sites)
            {
                if (site.Any(c => char.IsDigit(c)))
                {
                    sb.AppendLine($"Invalid URL!");
                }
                else
                {
                    sb.AppendLine($"Browsing: {site}!");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string Calling()
        {
            var sb = new StringBuilder();

            foreach (var call in this.calls)
            {
                if (call.Any(c => char.IsDigit(c)))
                {
                    sb.AppendLine($"Calling... {call}");
                }
                else
                {
                    sb.AppendLine("Invalid number!");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
