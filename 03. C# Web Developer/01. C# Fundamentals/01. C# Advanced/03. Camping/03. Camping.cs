namespace _03.Camping
{

    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Problem03
    {

        static Dictionary<string, Dictionary<string, int>> dict;
             
        public static void Main()
        {
            dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                AddInfoInDict(inputLine);
                
            }

            PrintResult();
        }

        public static void AddInfoInDict(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var name = arr[0];
            var model = arr[1];
            var nights = int.Parse(arr[2]);

            if (!dict.ContainsKey(name))
            {
                dict[name] = new Dictionary<string, int>();
            }

            dict[name][model] = nights;
        }

        public static void PrintResult()
        {
            foreach (var kvp in dict
                .OrderByDescending(n => n.Value.Count)
                .ThenBy(n => n.Key.Length))
            {
                var name = kvp.Key;
                var campersCnt = kvp.Value.Count;
                Console.WriteLine($"{name}: {campersCnt}");
                Console.WriteLine("***{0}",
                    string.Join(Environment.NewLine + "***", kvp.Value.Keys));
                Console.WriteLine("Total stay: {0} nights", kvp.Value.Values.Sum());
            }
        }
    }
}
