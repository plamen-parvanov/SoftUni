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

            var list = new List<char>();
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
                    list.Add(symbol);
                }
            }

            Console.WriteLine(string.Join("", list));
        }
    }
}
