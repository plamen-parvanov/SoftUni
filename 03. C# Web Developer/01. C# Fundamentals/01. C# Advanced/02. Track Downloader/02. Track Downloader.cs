namespace _02.Track_Downloader
{

    using System;
    using System.Collections.Generic;

    public class Problem02
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var blackListWords = InitializeList(inputLine);
            var resultList = new List<string>();

            while (true)
            {
                var currLine = Console.ReadLine();
                if (currLine.Equals("end"))
                {
                    break;
                }

                if (NotFromBlackList(currLine, blackListWords))
                {
                    resultList.Add(currLine);
                }
            }

            resultList.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, resultList));

        }

        public static List<string> InitializeList(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>();

            foreach (var str in inputArr)
            {
                list.Add(str);
            }

            return list;
        }

        public static bool NotFromBlackList(string currLine, List<string> blackListWords)
        {
            foreach (var word in blackListWords)
            {
                if (currLine.Contains(word))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
