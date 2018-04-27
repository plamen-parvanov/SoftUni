namespace _02.Count_Real_Numbers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem02
    {

        public static void Main()
        {
            var doubleArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var sortedDict = InitializeDict(doubleArr);

            PrintDict(sortedDict);

        }

        public static SortedDictionary<double, int> InitializeDict(double[] arr)
        {
            var dict = new SortedDictionary<double, int>();

            foreach (var num in arr)
            {
                if (!dict.Keys.Contains(num))
                {
                    dict[num] = 0;
                }

                dict[num]++;
            }

            return dict;
        }

        public static void PrintDict(SortedDictionary<double, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
