namespace _04.Treasure_Map
{
    using System;
    using System.Text.RegularExpressions;

    public class Problem04
    {
        public static void Main()
        {
            var inputArr = ReadInput();

            foreach (var line in inputArr)
            {
                PrintDecodedInformationFrom(line);
            }
        }

        private static void PrintDecodedInformationFrom(string line)
        {
            var pattern = @"#[^#!]*?(?<![A-Za-z0-9])(?<street>[A-Za-z]{4})(?![A-Za-z0-9])[^#!]*(?<!\d)(?<number>\d{3})-(?<pass>\d{4}|\d{6})(?!\d)[^#!]*!|![^#!]*?(?<![A-Za-z0-9])(?<street>[A-Za-z]{4})(?![A-Za-z0-9])[^#!]*(?<!\d)(?<number>\d{3})-(?<pass>\d{4}|\d{6})(?!\d)[^#!]*#";
            var matches = Regex.Matches(line, pattern);
            var count = matches.Count;
            var info = matches[count / 2];
            var addressName = info.Groups["street"].Value;
            var streetNumber = info.Groups["number"].Value;
            var password = info.Groups["pass"].Value;

            Console.WriteLine($"Go to str. {addressName} {streetNumber}. Secret pass: {password}.");

        }

        private static string[] ReadInput()
        {
            var lines = int.Parse(Console.ReadLine());
            var arr = new string[lines];

            for (int i = 0; i < lines; i++)
            {
                var currLine = Console.ReadLine();
                arr[i] = currLine;
            }

            return arr;
        }

    }
}
