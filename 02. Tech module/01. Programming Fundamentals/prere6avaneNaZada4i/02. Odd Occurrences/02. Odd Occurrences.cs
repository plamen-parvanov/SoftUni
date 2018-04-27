namespace _02.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dictionaries
    {
        public static void Main()
        {
            var inputWordArr = Console.ReadLine().ToLower().Split().ToArray();

            var wordDict = CountWordsFromInput(inputWordArr);

            var wordWithOddValue = GetWordInOddPosition(wordDict);

            Console.WriteLine(string.Join(", ", wordWithOddValue));

        }

        public static Dictionary<string, int> CountWordsFromInput(string[] inputWordArr)
        {
            var wordDict = new Dictionary<string, int>();

            foreach (var word in inputWordArr)
            {
                if (!wordDict.Keys.Contains(word))
                {
                    wordDict[word] = 0;
                }

                wordDict[word]++;
            }

            return wordDict;
        }

        public static List<string> GetWordInOddPosition(Dictionary<string, int> wordDict)
        {
            var wordWithOddValue = new List<string>();

            foreach (var word in wordDict)
            {
                if (word.Value % 2 != 0)
                {
                    wordWithOddValue.Add(word.Key);
                }
            }

            return wordWithOddValue;
        }
    }
}
