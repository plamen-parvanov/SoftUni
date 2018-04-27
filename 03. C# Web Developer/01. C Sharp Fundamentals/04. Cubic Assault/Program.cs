namespace _04.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {
        private static Dictionary<string, Dictionary<string, long>> dict;

        public static void Main()
        {
            ReadInput();

            PrintResult();
        }

        private static void PrintResult()
        {
            //regions ordered by the amount of Black Meteors – descending,
            //then by the length of their names – ascending,
            //and lastly alphabetically

            var orderedRegions = dict
                .OrderByDescending(x => x.Value["Black"])
                .ThenBy(x => x.Key.Length)
                .ThenBy(x => x.Key);

            foreach (var region in orderedRegions)
            {
                Console.WriteLine(region.Key);

                Print(region.Value);
            }
        }

        private static void Print(Dictionary<string, long> dragons)
        {
            //amount of defeated units in them – descending, 
            //and if two are with the same value, order them alphabetically

            var orderedDragons = dragons
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);

            foreach (var dragon in orderedDragons)
            {
                var name = dragon.Key;
                var count = dragon.Value;

                Console.WriteLine($"-> {name} : {count}");
            }
                
        }

        private static void ReadInput()
        {
            dict = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Count em all")
                {
                    break;
                }

                AddToDictionary(inputLine);
            }
        }

        private static void AddToDictionary(string inputLine)
        {
            var arr = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var region = arr[0];
            var typeDragon = arr[1];
            var count = long.Parse(arr[2]);

            if (!dict.ContainsKey(region))
            {
                CreateDictInThisRegion(region);
 
            }

            dict[region][typeDragon] += count;

            if (dict[region][typeDragon] >= 1000000)
            {
                ExecuteInreasing(typeDragon, region);
            }
        }

        private static void CreateDictInThisRegion(string region)
        {
            dict[region] = new Dictionary<string, long>();
            dict[region]["Red"] = 0;
            dict[region]["Green"] = 0;
            dict[region]["Black"] = 0;
        }

        private static void ExecuteInreasing(string typeDragon, string region)
        {
            if (typeDragon == "Green")
            {
                var add = dict[region][typeDragon] / 1000000;
                dict[region][typeDragon] %= 1000000;
                dict[region]["Red"] += add;

                if (dict[region]["Red"] >= 1000000)
                {
                    ExecuteInreasing("Red", region);
                }
            }
            else if (typeDragon == "Red")
            {
                var add = dict[region][typeDragon] / 1000000;
                dict[region][typeDragon] %= 1000000;
                dict[region]["Black"] += add;
            }
           
        }
    }
}
