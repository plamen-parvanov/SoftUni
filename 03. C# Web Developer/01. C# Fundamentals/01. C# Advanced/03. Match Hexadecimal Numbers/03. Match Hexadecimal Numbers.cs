namespace _03.Match_Hexadecimal_Numbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var matches = Regex.Matches(input, pattern);
            var result = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
