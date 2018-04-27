namespace _04.Jedi_Dreams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem04
    {
        public static void Main()
        {
            var dict = new Dictionary<string, List<string>>();

            AddMethodsIn(dict);

            Print(dict);
        }

        private static void Print(Dictionary<string, List<string>> dict)
        {
            foreach (var method in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                var name = method.Key;
                var count = method.Value.Count;
                var invoked = method.Value.OrderBy(x => x).ToArray();

                Console.WriteLine($"{name} -> {count} -> {string.Join(", ", invoked)}");
            }
        }

        private static void AddMethodsIn(Dictionary<string, List<string>> dict)
        {
            var n = int.Parse(Console.ReadLine());
            var methodName = string.Empty;
            var invkoed = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var currLine = Console.ReadLine();

                if (currLine.Contains("static"))
                {
                    methodName = GetMethodName(currLine);
                    dict[methodName] = new List<string>();
                    continue;
                }

                if (methodName != string.Empty)
                {
                    AddInvkoedNames(currLine, dict[methodName]);
                }
                
            }
        }

        private static void AddInvkoedNames(string input, List<string> list)
        {
            var pattern = @"(?<name>[A-Za-z]*[A-Z][a-zA-Z]*)\s*\(";
            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                list.Add(match.Groups["name"].Value);
            }
        }

        private static string GetMethodName(string input)
        {
            var pattern = @"static\s+.+\s+(?<name>[A-Za-z]*[A-Z][a-zA-Z]*)\s*\(";
            var match = Regex.Match(input, pattern);

            return match.Groups["name"].Value;
        }

        
    }
}
