namespace _02.Cities_by_Continent_and_Country
{

    using System;
    using System.Collections.Generic;

    public class Problem02
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            AddingCitiesInDict(n, dict);

            PrintDict(dict);
        }

        public static void AddingCitiesInDict(
            int n, Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var continent = inputLine[0];
                var country = inputLine[1];
                var city = inputLine[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }

                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new List<string>();
                }

                dict[continent][country].Add(city);
            }
        }

        public static void PrintDict(Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            foreach (var kvp in dict)
            {
                var continent = kvp.Key;
                Console.WriteLine($"{continent}:");

                foreach (var kvp2 in kvp.Value)
                {
                    var country = kvp2.Key;
                    var cities = kvp2.Value;

                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", cities));
                }
            }

        }
    }
}
