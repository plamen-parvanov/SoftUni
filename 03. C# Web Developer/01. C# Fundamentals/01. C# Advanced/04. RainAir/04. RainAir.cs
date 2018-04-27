namespace _04.RainAir
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static Dictionary<string, SortedSet<int>> dict;  // ako se polzva list dava 100,
        static void Main()                                      // no pouslovie (add new once)
        {
            ReadInput();

            PrintResult();
        }

        private static void ReadInput()
        {
            dict = new Dictionary<string, SortedSet<int>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "I believe I can fly!")
                {
                    break;
                }

                AddInfoInDictFrom(inputLine);
            }
        }

        private static void AddInfoInDictFrom(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = arr[0];
            if (!dict.ContainsKey(name))
            {
                dict[name] = new SortedSet<int>();
            }

            if (arr[1] == "=")
            {
                var listToCopy = dict[arr[2]];
                dict[name] = new SortedSet<int>(listToCopy);
            }
            else
            {
                var flights = arr.Skip(1).Select(int.Parse).ToList();
                flights.ForEach(x => dict[name].Add(x));
            }
        }

        private static void PrintResult()
        {
            foreach (var person in dict.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                var name = person.Key;
                var flights = person.Value;

                Console.WriteLine($"#{name} ::: {string.Join(", ", flights)}");
            }
        }
    }
}
