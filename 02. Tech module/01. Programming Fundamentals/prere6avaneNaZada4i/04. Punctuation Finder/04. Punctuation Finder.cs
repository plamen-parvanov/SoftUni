namespace _04.Punctuation_Finder
{

    using System;
    using System.Collections.Generic;
    using System.IO;


    public class Program
    {

        public static void Main()
        {

            var text = File.ReadAllText("sample_text.txt");

            var listMarks = new List<char>();
            var searchList = new List<char>()
            {
                '.',
                ',',
                '!',
                '?',
                ':'
            };

            foreach (var symbol in text)
            {
                if (!searchList.Contains(symbol))
                {
                    listMarks.Add(symbol);  
                }
            }

            Console.WriteLine(string.Join("", listMarks));
        }
    }
}
