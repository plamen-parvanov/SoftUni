namespace _04.Match_Dates
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem04
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"\b(?<day>\d{2})([.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            var dates = Regex.Matches(input, pattern);

            Print(dates);
        }

        private static void Print(MatchCollection dates)
        {
            foreach (Match date  in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
