namespace _04.CODE_Phoenix_Oscar_Romeo_November
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        public static Dictionary<string, HashSet<string>> dict;
        public static Dictionary<string, HashSet<string>> result;
        public static void Main()
        {
            dict = new Dictionary<string, HashSet<string>>();
            result = new Dictionary<string, HashSet<string>>();

            ReadInput();

            RemoveMatesFromCount();

            PrintResult();
        }

        private static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Blaze it!")
                {
                    break;
                }

                Read(inputLine);
            }
        }

        private static void Read(string input)
        {
            var arr = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var creature = arr[0];
            var mate = arr[1];

            if (creature == mate)
            {
                return;
            }

            if (!dict.ContainsKey(creature))
            {
                dict[creature] = new HashSet<string>();
            }

            dict[creature].Add(mate);
        }

        private static void RemoveMatesFromCount()
        {
            foreach (var kvp in dict)
            {
                var creature = kvp.Key;
                if (!result.ContainsKey(creature))
                {
                    result[creature] = new HashSet<string>();
                }

                var mates = kvp.Value;

                foreach (var mate in mates)
                {
                    if (!dict.ContainsKey(mate) || !dict[mate].Contains(creature))
                    {
                        result[creature].Add(mate);
                    }
                }
            }
        }

        private static void PrintResult()
        {
            result
                .OrderByDescending(x => x.Value.Count)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} : {x.Value.Count()}"));
        }
    }
}
