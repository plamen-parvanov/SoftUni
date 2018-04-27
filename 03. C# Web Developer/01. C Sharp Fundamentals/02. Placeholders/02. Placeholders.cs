using System;
using System.Text;

namespace _02.Placeholders
{
    public class Problem02
    {
        public static void Main()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                var result = ReadLine(inputLine);
                Console.WriteLine(string.Join(" ", result));
            }

        }

        public static string[] ReadLine(string input)
        {
            var split = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var textArr = split[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var replacements = split[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var replaced = new string[textArr.Length];

            for (int i = 0; i < textArr.Length; i++)
            {
                var currWord = textArr[i];
                if (currWord.Contains("{") && currWord.Contains("}"))
                {
                    var start = currWord.IndexOf("{");
                    var end = currWord.IndexOf("}");
                    var index = int.Parse(currWord.Substring(start + 1, end - start - 1));
                   

                    if (replacements.Length > index)
                    {
                        currWord = replacements[index];
                    }
                }

                replaced[i] = currWord;
            }

            return replaced;
        }
    }
}
