namespace _04.Shellbound
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {

        public static void Main()
        {
            var dict = new Dictionary<string, HashSet<int>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Aggregate")
                {
                    break;
                }

                var inputArr = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var region = inputArr[0];
                var shell = int.Parse(inputArr[1]);

                if (!dict.ContainsKey(region))
                {
                    dict[region] = new HashSet<int>();
                }

                dict[region].Add(shell);
            }

            PrintResult(dict);
        }

        public static void PrintResult(Dictionary<string, HashSet<int>> dict)
        {
            foreach (var kvp in dict)
            {
                var region = kvp.Key;
                var shells = string.Join(", ", kvp.Value);
                var sum = kvp.Value.Sum();
                var giantShell = sum - sum / kvp.Value.Count;

                Console.WriteLine($"{region} -> {shells} ({giantShell})");
            }
        }
    }
}
