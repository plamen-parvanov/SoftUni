namespace _02.Default_Values
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            var dict = new Dictionary<string, string>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                var arr = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var key = arr[0];
                var value = arr[1];

                if (!dict.ContainsKey(key))
                {
                    dict[key] = string.Empty;
                }

                dict[key] = value;
            }
            var noNullValues = dict.Where(v => v.Value != "null")
                .OrderByDescending(v => v.Value.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            var replacement = Console.ReadLine();
            var replacedValues = dict.Where(v => v.Value == "null").ToDictionary(k => k.Key, v => replacement);

            PrintDict(noNullValues);
            PrintDict(replacedValues);
        }

        public static void PrintDict(Dictionary<string, string> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
        }
    }
}
