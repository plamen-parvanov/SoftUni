namespace _02.Worm_Ipsum
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem02
    {
        public static void Main()
        {
            ReadInput();
        }

        private static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Worm Ipsum")
                {
                    break;
                }
                else if (IsNotValidSentence(inputLine))
                {
                    continue;
                }

                PrintChanged(inputLine);

            }
        }

        private static bool IsNotValidSentence(string input)
        {
            return !Regex.IsMatch(input, @"^[A-Z][^.]+\.$");
        }

        private static void PrintChanged(string input)
        {
            var arr = input
                .Split(",:;'\"()`- .".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                var currWord = arr[i];
                if (currWord == string.Join("", currWord.Distinct()))
                {
                    continue;
                }

                currWord = ReplaceChar(currWord);

                input = input.Replace(arr[i], currWord);
            }

            Console.WriteLine(input);
        }

        private static string ReplaceChar(string word)
        {
            var symbol = word.GroupBy(c => c)
                     .ToDictionary(grp => grp.Key, grp => grp.Count())
                     .OrderByDescending(v => v.Value)
                     .First()
                     .Key;
            return new string(symbol, word.Length);
        }
    }
}
