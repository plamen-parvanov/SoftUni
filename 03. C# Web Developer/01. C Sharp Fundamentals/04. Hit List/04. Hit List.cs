namespace _04.Hit_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static void Main()
        {
            var targetIndex = int.Parse(Console.ReadLine());

            var dict = InitializeDict();

            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var name = input[1];

            PrintInfoForThis(name, dict[name], targetIndex);
        }

        private static void PrintInfoForThis(string name, SortedList<string, string> sortedList, int num)
        {
            Console.WriteLine($"Info on {name}:");

            foreach (var kvp in sortedList)
            {
                var info = kvp.Key;
                var value = kvp.Value;

                Console.WriteLine($"---{info}: {value}");
            }

            var sumKeys = sortedList.Sum(k => k.Key.Length);
            var sumValues = sortedList.Sum(v => v.Value.Length);
            var infoIndex = sumKeys + sumValues;

            Console.WriteLine($"Info index: {infoIndex}");

            if (infoIndex >= num)
            {
                Console.WriteLine("Proceed");
            }
            else
            {
                var infoNeeded = num - infoIndex;

                Console.WriteLine($"Need {infoNeeded} more info.");
            }
        }

        private static Dictionary<string, SortedList<string, string>> InitializeDict()
        {
            var dict = new Dictionary<string, SortedList<string, string>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end transmissions")
                {
                    break;
                }

                AddingInfoIn(dict, input);
            }

            return dict;
        }

        private static void AddingInfoIn(Dictionary<string, SortedList<string, string>> dict, string info)
        {
            var arr = info
                .Split(new[] { '=', ':', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = arr[0];

            if (!dict.ContainsKey(name))
            {
                dict[name] = new SortedList<string, string>();
            }

            for (int i = 1; i < arr.Length; i += 2)
            {
                var key = arr[i];
                var value = arr[i + 1];

                dict[name][key] = value;
            }
        }

    }
}
