namespace _05.Short_Words_Sorted
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Discionaries
    {

        public static void Main()
        {
            var wordList = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = wordList.OrderBy(x => x)
                .Distinct()
                .Where(x => x.Length < 5)
                .ToList();

            Console.WriteLine(string.Join(", ", result));

        }
    }
}
