namespace _03._Ticket_Trouble
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        public static void Main()
        {
            var samLocation = Console.ReadLine();

            var seats = GetSamsSeats(samLocation);

            var firstSeat = seats[0];
            var secondSeat = seats[1];

            Console.WriteLine(
                $"You are traveling to {samLocation} on seats {firstSeat} and {secondSeat}.");


        }

        private static string[] GetSamsSeats(string samLocation)
        {
            var input = Console.ReadLine();
            var pattern = @"((?<temp>{)|\[)[^\[{]*(?(temp)\[|{)(?<location>[A-Z]{3} [A-Z]{2})(?(temp)\]|})[^\[\]}{]*(?(temp)\[|{)(?<seat>[A-Z](?<row>\d{1,2}))(?(temp)\]|})[^\[\]}{]*(?(temp)}|])";

            var matches = Regex.Matches(input, pattern);
            var filtered = matches
                .Where(x => x.Groups["location"].Value == samLocation)
                .ToArray();

            return GetTwoSeats(filtered);
        }

        private static string[] GetTwoSeats(Match[] filtered)
        {
            if (filtered.Count() == 2)
            {
                return new string[2]
                {
                    filtered[0].Groups["seat"].Value,
                    filtered[1].Groups["seat"].Value
                };
            }

            var ordered = filtered.OrderBy(x => x.Groups["row"].Value)
                .ToArray();

           

            for (int i = 0; i < ordered.Count() - 1; i++)
            {
                var curr = ordered[i].Groups["row"].Value;
                var next = ordered[i + 1].Groups["row"].Value;

                if (curr == next)
                {
                    return new string[2] 
                    {
                        ordered[i].Groups["seat"].Value,
                        ordered[i + 1].Groups["seat"].Value
                    };
                }

            }

            return null;

        }
    }
}
