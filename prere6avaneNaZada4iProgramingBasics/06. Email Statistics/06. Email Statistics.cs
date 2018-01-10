namespace _06.Email_Statistics
{

    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;


    public class Program
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var emails = new Dictionary<string, HashSet<string>>();
            var pattern = 
                @"^(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}[.](com|bg|org))$";

            var regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                var wantedEmail = Console.ReadLine();

                if (regex.IsMatch(wantedEmail))
                {
                    var match = regex.Match(wantedEmail);

                    var username = match.Groups["username"].Value;
                    var domain = match.Groups["domain"].Value;

                    if (! emails.ContainsKey(domain))
                    {
                        emails[domain] = new HashSet<string>();
                    }

                    emails[domain].Add(username);
                }

            }
            var emailsOrdered = emails.OrderByDescending(x => x.Value.Count);

            foreach (var kvp in emailsOrdered)
            {
                Console.WriteLine(kvp.Key + ":");

                foreach (var username in kvp.Value)
                {
                    Console.WriteLine("### {0}", username);
                }
            }
        }
    }
}
