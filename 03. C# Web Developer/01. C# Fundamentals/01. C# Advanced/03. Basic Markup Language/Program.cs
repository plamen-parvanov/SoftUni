namespace _03.Basic_Markup_Language
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        private static int cntr;
        public static void Main()
        {
            cntr = 1;
            var pattern = @"\s*<\s*(?<operation>[a-zA-Z]+)(\s+[a-zA-Z]+\s*=\s*""\s*(?<value>\d+)\s*\""\s*)*?(\s+content\s*=\s*""(?<content>[^\""]+)"")*\s*\/\s*\>\s*";

            while (true)
            {
                var inputLine = Console.ReadLine();

                var match = Regex.Match(inputLine, pattern);
                var operation = match.Groups["operation"].Value.Trim();

                if (operation == "stop")
                {
                    break;
                }
                else if (operation == string.Empty)
                {
                    continue;
                }

                ExecuteOperationAndPrint(match);

            }
        }

        private static void ExecuteOperationAndPrint(Match match)
        {
            var operation = match.Groups["operation"].Value.Trim();
            var content = match.Groups["content"].Value;
            if (content == string.Empty)
            {
                return;
            }
            var result = string.Empty;

            switch (operation)
            {
                case "inverse":
                    result = Invert(content);
                    Print(result, 1);
                    break;

                case "reverse":
                    result = Reverse(content);
                    Print(result, 1);
                    break;

                case "repeat":
                    var value = int.Parse(match.Groups["value"].Value);
                    Print(content, value);
                    break;

                default:
                    break;
            }
            
        }

        private static void Print(string word, int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine($"{cntr}. {word}");
                cntr++;
            }
        }

        private static string Reverse(string word)
        {
            var result = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                result.Append(word[i]);
            }

            return result.ToString();
        }

        private static string Invert(string word)
        {
            var result = new StringBuilder();

            foreach (var letter in word)
            {
                if (char.IsLower(letter))
                {
                    result.Append(letter.ToString().ToUpper());

                    continue;
                }

                result.Append(letter.ToString().ToLower());
            }

            return result.ToString();
        }
    }
}
