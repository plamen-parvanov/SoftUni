namespace _01.Odd_Occurrences
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem01
    {

        public static void Main()
        {
            var wordArr = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var dict = InitializeDict(wordArr);

            var wordsOddNumberOfTimes = AddOddNumberOfTimesWors(dict);

            Console.WriteLine(string.Join(", ", wordsOddNumberOfTimes));

        }

        public static Dictionary<string, int> InitializeDict(string[] wordArr)
        {
            var dict = new Dictionary<string, int>();

            foreach (var word in wordArr)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 0;
                }

                dict[word]++;
            }

            return dict;
        }

        public static List<string> AddOddNumberOfTimesWors(Dictionary<string, int> dict)
        {
            var result = new List<string>();

            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 != 0)
                {
                    result.Add(kvp.Key);
                }
            }

            return result;
        }
    }
}
