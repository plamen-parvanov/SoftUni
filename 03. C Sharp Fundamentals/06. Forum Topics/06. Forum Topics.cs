namespace _06.Forum_Topics
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem06
    {

        public static void Main()
        {
            var dict = new Dictionary<string, List<string>>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "filter")
                {
                    break;
                }

                var arr = command.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var key = arr[0];

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }

                dict[key].AddRange(arr[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
                dict[key] = dict[key].Distinct().ToList();
            }

            var tags = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Print(tags, dict);
        }

        public static void Print(string[] tags, Dictionary<string, List<string>>dict)
        {
            foreach (var kvp in dict)
            {
                var currTopic = kvp.Key;
                var all = kvp.Value;
                if (Contains(all, tags))
                {
                    Console.WriteLine("{0} | #{1}", currTopic, string.Join(", #", all));
                }
            }
        }

        public static bool Contains(List<string> allTags, string[] tags)
        {
            foreach (var tag in tags)
            {
                if (!allTags.Contains(tag))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
