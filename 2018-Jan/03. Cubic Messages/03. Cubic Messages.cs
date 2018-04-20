namespace _03.Cubic_Messages
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Text;

    public class Problem03
    {
        public static void Main()
        {
            var pattern = @"^(?<before>\d+)(?<msg>[A-Za-z]+)(?<after>[^A-Za-z]*)$";

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Over!")
                {
                    break;
                }
                
                var codeLength = int.Parse(Console.ReadLine());

                var match = Regex.Match(inputLine, pattern);
                if (match.Groups["msg"].Value.Length != codeLength)
                {
                    continue;
                }

                PrintOutput(match);

            }
        }

        private static void PrintOutput(Match match)
        {
            var msg = match.Groups["msg"].Value;

            var before = match.Groups["before"].Value;
            var firstPart = Decrypt(before, msg);

            var after = match.Groups["after"].Value;
            var lastPart = Decrypt(after, msg);

            Console.WriteLine($"{msg} == {firstPart}{lastPart}");
        }

        private static string Decrypt(string input, string code)
        {
            var indexes = input
                .Where(x => char.IsDigit(x))
                .Select(x => x - '0')
                .ToArray();

            var result = new StringBuilder();
            var length = code.Length;

            foreach (var index in indexes)
            {
                if (index < 0 || index >= length)
                {
                    result.Append(" ");
                    continue;
                }

                result.Append(code[index]);
            }

            return result.ToString();
        }
    }
}
