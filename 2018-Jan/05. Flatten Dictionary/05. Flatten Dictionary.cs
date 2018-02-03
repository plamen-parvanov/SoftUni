namespace _05.Flatten_Dictionary
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem05
    {
        static Dictionary<string, Dictionary<string, string>> inner;
        static Dictionary<string, List<string>> flattered;

        public static void Main()
        {
            inner = new Dictionary<string, Dictionary<string, string>>();
            flattered = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (arr[0] == "flatten")
                {
                    ExecuteFlatten(arr[1]);
                }
                else
                {
                    StoreInInner(arr);
                }
            }
            
            PrintResult();
        }

        public static void StoreInInner(string[] arr)
        {
            var key = arr[0];
            var innerKey = arr[1];
            var innerValue = arr[2];

            if (!inner.ContainsKey(key))
            {
                inner[key] = new Dictionary<string, string>();
            }

            inner[key][innerKey] = innerValue;
        }

        public static void ExecuteFlatten(string key)
        {    
            if (!flattered.ContainsKey(key))
            {
                flattered[key] = new List<string>();
            }

            foreach (var kvp in inner[key])
            {
                var innerKey = kvp.Key;
                var innerValue = kvp.Value;
                var concat = innerKey + innerValue;
                flattered[key].Add(concat);
            }

            inner[key].Clear();
        }

        public static void PrintResult()
        {
            foreach (var kvp in inner.OrderByDescending(k => k.Key.Length))
            {
                var key = kvp.Key;
                var values = kvp.Value;
                var cntr = 0;
                if (values.Count != 0)
                {                    
                    Console.WriteLine($"{key}");
                    foreach (var innerValue in values.OrderBy(i => i.Key.Length))
                    {
                        cntr++;
                        Console.WriteLine($"{cntr}. {innerValue.Key} - {innerValue.Value}");
                    }
                }

                if (flattered.ContainsKey(key))
                {                   
                    foreach (var value in flattered[key])
                    {
                        cntr++;
                        Console.WriteLine($"{cntr}. {value}");
                    }
                }
            }
        }

    }
}
