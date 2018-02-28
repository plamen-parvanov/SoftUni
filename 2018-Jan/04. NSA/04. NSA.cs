namespace _04.NSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static Dictionary<string, List<Spy>> dict;
        public static void Main()
        {
            dict = new Dictionary<string, List<Spy>>();

            ReadInput();

            PrintDict();
        }

        private static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "quit")
                {
                    break;
                }

                AddToDict(inputLine);
            }
        }

        private static void AddToDict(string input)
        {
            var arr = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var countryName = arr[0];
            var spyName = arr[1];
            var daysInService = int.Parse(arr[2]);

            if (!dict.ContainsKey(countryName))
            {
                dict[countryName] = new List<Spy>();
            }

            if (dict[countryName].Any(x => x.Name == spyName))
            {
                dict[countryName].RemoveAll(x => x.Name == spyName);
            }

            dict[countryName].Add(new Spy(spyName, daysInService));
        }

        private static void PrintDict()
        {
            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count))
            {
                var countryName = kvp.Key;

                Console.WriteLine($"Country: {countryName}");

                foreach (var spy in kvp.Value.OrderByDescending(x => x.DaysInServ))
                {
                    Console.WriteLine($"**{spy.Name} : {spy.DaysInServ}");
                }
            }
        }
    }
}
