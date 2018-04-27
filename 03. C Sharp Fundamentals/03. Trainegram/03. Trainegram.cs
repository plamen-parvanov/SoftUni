namespace _03.Trainegram
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Problem03
    {
        public static List<string> trains;
        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            trains = new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Traincode!")
                {
                    break;
                }

                AddValidTrainsToList(inputLine);
            }
        }

        public static void AddValidTrainsToList(string input)
        {
            var pattern = @"^<\[[^A-Za-z0-9]*?\]\.(\.\[[A-Za-z0-9]*?\]\.)*$";
            var regex = new Regex(pattern);
            if(regex.IsMatch(input))
            {
                trains.Add(regex.Match(input).Value);
            }
        }

        private static void PrintResult()
        {
            Console.WriteLine(string.Join(Environment.NewLine, trains));
        }
    }
}
