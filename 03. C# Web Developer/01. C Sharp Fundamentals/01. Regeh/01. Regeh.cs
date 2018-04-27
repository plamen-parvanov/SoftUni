namespace _01.Regeh
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem01
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputLength = input.Length;

            var pattern = @"\[[a-zA-Z]+<(?<first>\d+)REGEH(?<second>\d+)>[a-zA-Z]+?\]";
            var matches = Regex.Matches(input, pattern);
            var result = string.Empty;
            var index = 0;

            foreach  (Match match in matches)
            {
                index += int.Parse(match.Groups["first"].Value);
                var firstSymbolIndex = index % inputLength;
                result += input[firstSymbolIndex];

                index += int.Parse(match.Groups["second"].Value);
                var secondSymbolIndex = index % inputLength;
                result += input[secondSymbolIndex];
            }

            Console.WriteLine(result);
        }
    }
}
