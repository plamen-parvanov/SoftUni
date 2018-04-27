namespace _02.Spy_Gram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem02
    {
        public static SortedDictionary<string, List<string>> dict;
        public static void Main()
        {
            dict = new SortedDictionary<string, List<string>>();

            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            var key = Console.ReadLine();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                else if (!IsValid(inputLine))
                {
                    continue;
                }

                var name = GetName(inputLine);
                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<string>();
                }

                dict[name].Add(Encripted(inputLine, key));
            }
        }

        private static bool IsValid(string input)
        {
            return Regex.IsMatch(input, @"^TO: [A-Z]+; MESSAGE: .+?;$");
        }

        private static string GetName(string input)
        {
            return Regex.Match(input, @"^TO: (?<name>[A-Z]+); MESSAGE: .+?;$")
                        .Groups["name"]
                        .Value;
        }

        private static string Encripted(string input, string key)
        {
            var result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result += (char)(input[i] + key[i % key.Length] - '0');
            }

            return result;
        }

        private static void PrintResult()
        {
            dict.Values
                .ToList()
                .ForEach(x => Console.WriteLine(string.Join(Environment.NewLine, x)));
        }
    }
}
