namespace _02.Match_Phone_Number
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem02
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(?: |^)\+359( |-)2\1\d{3}\1\d{4}\b";
            //var regex = new Regex(pattern);
            //var matches = regex.Matches(input);

             var matches = Regex.Matches(input, pattern);

            var result = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }     
    }
}
