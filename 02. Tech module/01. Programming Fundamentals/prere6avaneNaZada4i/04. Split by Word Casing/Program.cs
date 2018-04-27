namespace _04.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Lists
    {
        public static void Main()
        {
            var inputList = Console.ReadLine()
                            .Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']')
                            .ToList();

            var wordList = new List<string>();
            var mixedWordList = new List<string>();
            var upperWordList = new List<string>();
            var lowerWordList = new List<string>();

            RemoveEmptyStrings(inputList, wordList);

            CheckEachWordLetters(wordList, mixedWordList, upperWordList, lowerWordList);

            Console.Write("Lower-case: ");
            PrintWords(lowerWordList);
            Console.Write("Mixed-case: ");
            PrintWords(mixedWordList);
            Console.Write("Upper-case: ");
            PrintWords(upperWordList);


        }

        public static void PrintWords(List<string> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }

        private static void CheckEachWordLetters(List<string> wordList, List<string> mixedWordList, List<string> upperWordList, List<string> lowerWordList)
        {
            foreach (var word in wordList)
            {
                if (word[0] >= 'a' && word[0] <= 'z')
                {
                    CheckLowerUpperOrMixed(mixedWordList, lowerWordList, word, 'a', 'z');
                }
                else if (word[0] >= 'A' && word[0] <= 'Z')
                {
                    CheckLowerUpperOrMixed(mixedWordList, upperWordList, word, 'A', 'Z');
                }
                else
                {
                    mixedWordList.Add(word);
                }
            }
        }

        public static void CheckLowerUpperOrMixed(List<string> mixedWordList, List<string> lowerWordList, string word, char start, char end)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] >= start && word[i] <= end)
                {
                    continue;
                }
                else
                {
                    mixedWordList.Add(word);
                    return;
                }
            }
            lowerWordList.Add(word);
        }

        public static void RemoveEmptyStrings(List<string> inputList, List<string> wordList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] != "")
                {
                    wordList.Add(inputList[i]);
                }
            }
        }
    }
}
