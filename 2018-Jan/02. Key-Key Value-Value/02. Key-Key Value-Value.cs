namespace _02.Key_Key_Value_Value
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {

        public static void Main()
        {
            var key = Console.ReadLine();
            var value = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();

                AddingPairsEqualToKeyAndValue(inputLine, result, key, value);
            }

            Print(result);

        }

        public static void AddingPairsEqualToKeyAndValue(
            string input, Dictionary<string, List<string>>dict, string key, string value)
        {
            var inputArr = input.Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
            var currKey = inputArr[0];
            var currValues = inputArr[1]
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (currKey.Contains(key))
            {
                dict[currKey] = new List<string>();

                foreach (var val in currValues)
                {
                    if (val.Contains(value))
                    {
                        dict[currKey].Add(val);
                    }
                }
            }
        }

        public static void Print(Dictionary<string, List<string>> dict)
        {
            foreach (var kvp in dict)
            {
                var key = kvp.Key;
                var values = kvp.Value;
                Console.WriteLine($"{key}:");

                foreach (var value in values)
                {
                    Console.WriteLine($"-{value}");
                }
            }
        }
    }
}
