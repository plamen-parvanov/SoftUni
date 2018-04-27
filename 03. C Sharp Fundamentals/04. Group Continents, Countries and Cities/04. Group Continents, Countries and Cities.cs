namespace _04.Group_Continents__Countries_and_Cities
{

    using System;
    using System.Collections.Generic;

    public class Problem04
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            AddingInfoInDict(dict, n);

            Print(dict);

        }

        public static void AddingInfoInDict(
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> dict, int n)
        {
            for (int i = 0; i < n; i++)
            {
                var currLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currContinent = currLine[0];
                var currCountry = currLine[1];
                var currCity = currLine[2];

                if (!dict.ContainsKey(currContinent))
                {
                    dict[currContinent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!dict[currContinent].ContainsKey(currCountry))
                {
                    dict[currContinent][currCountry] = new SortedSet<string>();
                }

                dict[currContinent][currCountry].Add(currCity);
            }

        }

        public static void Print(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> dict)
        {
            foreach (var kvp in dict)
            {
                var continent = kvp.Key;
                Console.WriteLine($"{continent}:");

                foreach (var kvp2 in kvp.Value)
                {
                    var country = kvp2.Key;
                    var cities = string.Join(", ", kvp2.Value);

                    Console.WriteLine($"  {country} -> {cities}");
                }
            }
        }
    }
}
