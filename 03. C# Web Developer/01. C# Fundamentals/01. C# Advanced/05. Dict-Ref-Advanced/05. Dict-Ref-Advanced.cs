namespace _05.Dict_Ref_Advanced
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem05
    {

        public static void Main()
        {
            var dict = new Dictionary<string, List<int>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var inputArr = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var currKey = inputArr[0];
                var currValues = inputArr[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(currKey))
                {
                    dict[currKey] = new List<int>();
                }

                int temp;
                if (int.TryParse(currValues[0], out temp)) // [0] >= 0 && <= 9 
                {
                    dict[currKey].AddRange(currValues.Select(int.Parse));
                }
                else if (dict.ContainsKey(currValues[0]))
                {
                    var listToCopy = dict[currValues[0]];
                    dict[currKey].AddRange(listToCopy);
                }

            }

            PrintDict(dict);

        }

        public static void PrintDict(Dictionary<string, List<int>> dict)
        {
            foreach (var kvp in dict)
            {
                if (kvp.Value.Count == 0)
                {
                    continue;
                }
                Console.WriteLine("{0} === {1}", kvp.Key, string.Join(", ", kvp.Value));
            }
        }
    }
}
