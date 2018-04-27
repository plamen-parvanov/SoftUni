namespace _03.Jedi_Code_X
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        private static string input;
        public static void Main()
        {
            ReadLines();

            var namePattern = Console.ReadLine();
            var msgPattern = Console.ReadLine();

            var names = PrefixNames(namePattern);
            var msgs = PrefixMessages(msgPattern);

            PrintResult(names, msgs);
        }

        private static void PrintResult(List<string> names, List<string> msgs)
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x <= msgs.Count)
                .ToArray();

            var indexes = new Queue<int>(arr);

            foreach (var name in names)
            {
                if (indexes.Count == 0)
                {
                    break;
                }

                var msg = GetMessage(msgs, indexes);

                Console.WriteLine($"{name} - {msg}");
            }
        }

        private static string GetMessage(List<string> msgs, Queue<int> indexes)
        {
            var currIndex = indexes.Dequeue();

            return msgs[currIndex - 1];
        }

        private static List<string> PrefixNames(string patternInput)
        {
            var lenght = patternInput.Length;
            var pattern = $@"(?<={patternInput})([a-zA-Z]{{{lenght}}})";
            var matches = Regex.Matches(input, pattern);
            var list = new List<string>();

            foreach (var match in matches)
            {
                list.Add(match.ToString());
            }

            return list;
        }

        private static List<string> PrefixMessages(string patternInput)
        {
            var lenght = patternInput.Length;
            var pattern = $@"(?<={patternInput})([a-zA-Z0-9]{{{lenght}}})";
            var matches = Regex.Matches(input, pattern);
            var list = new List<string>();

            foreach (var match in matches)
            {
                list.Add(match.ToString());
            }

            return list;
        }

        private static void ReadLines()
        {
            var n = int.Parse(Console.ReadLine());
            var strBiulder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                strBiulder.Append(Console.ReadLine());
            }

            input = strBiulder.ToString();
        }
    }
}
