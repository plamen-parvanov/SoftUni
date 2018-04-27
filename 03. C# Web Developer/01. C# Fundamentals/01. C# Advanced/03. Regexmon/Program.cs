namespace _03.Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var firstPatthern = @"[^-A-Za-z]+";
            var secondPattern = @"[A-Za-z]+-[A-Za-z]+";
            var startIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var a = input.Substring(startIndex);
                var match = Regex.Match(input.Substring(i), firstPatthern);
                if (!match.Success)
                {
                    break;
                }

                Console.WriteLine(match);

                i += match.Index + match.Length;

                match = Regex.Match(input.Substring(i), secondPattern);
                if (!match.Success)
                {
                    break;
                }

                Console.WriteLine(match);

                i += match.Index + match.Length - 1;
            }
           
        }
    }
}
