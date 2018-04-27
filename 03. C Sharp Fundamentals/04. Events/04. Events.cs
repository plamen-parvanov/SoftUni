namespace _04.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem04
    {
        private static SortedDictionary<string, SortedDictionary<string, List<string>>> dict;

        public static void Main()
        {
            ReadInput();

            PrintEventsFromInputLocations();
        }

        private static void PrintEventsFromInputLocations()
        {
            var locations = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => dict.ContainsKey(x))
                .OrderBy(x => x)
                .ToArray();

            foreach (var location in locations)
            {
                Console.WriteLine($"{location}:");

                PrintAllEvents(location);
            }
        }

        private static void PrintAllEvents(string location)
        {
            var cntr = 1;

            foreach (var @event in dict[location])
            {
                var name = @event.Key;
                var events = @event.Value.OrderBy(x => x);

                Console.WriteLine($"{cntr}. {name} -> {string.Join(", ", events)}");

                cntr++;
            }

        }

        private static void ReadInput()
        {
            dict = new SortedDictionary<string, SortedDictionary<string, List<string>>>();

            var pattern = @"^#(?<person>[A-Za-z]+):\s*@(?<town>[A-Za-z]+)\s*(?<time>(?<hour>\d{1,2}):(?<min>\d{1,2}))$";

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currLine = Console.ReadLine();
                
                var match = Regex.Match(currLine, pattern);
               

                if (match.Success)
                {
                    var hours = int.Parse(match.Groups["hour"].Value);
                    var minutes = int.Parse(match.Groups["min"].Value);

                    if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
                    {
                        AddEventInDict(match);
                    }                   
                   
                }
            }
        }

        private static void AddEventInDict(Match match)
        {
            var name = match.Groups["person"].Value;
            var location = match.Groups["town"].Value;
            var time = match.Groups["time"].Value;

            if (!dict.ContainsKey(location))
            {
                dict[location] = new SortedDictionary<string, List<string>>();
            }

            if (!dict[location].ContainsKey(name))
            {
                dict[location][name] = new List<string>();
            }

            dict[location][name].Add(time);
        }
    }
}
