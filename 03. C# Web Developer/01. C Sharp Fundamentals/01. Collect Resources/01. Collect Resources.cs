namespace _01.Collect_Resources
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Problem01
    {
        private static string[] arr;
        public static void Main()
        {
            arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var paths = int.Parse(Console.ReadLine());
            var max = int.MinValue;

            for (int i = 0; i < paths; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                var start = inputLine[0];
                var step = inputLine[1];

                var result = CalculateResourcesFrom(start, step);

                if (result > max)
                {
                    max = result;
                }
            }

            Console.WriteLine(max);

        }

        private static int CalculateResourcesFrom(int index, int step)
        {
            var stepedOn = new bool[arr.Length];
            var result = 0;

            while (true)
            {
                if (stepedOn[index])
                {
                    break;
                }

                var currField = arr[index];

                result += GetResourceFrom(currField);

                stepedOn[index] = true;
                index += step;
                index %= arr.Length;
            }

            return result;
        }

        private static int GetResourceFrom(string field)
        {
            var pattern = @"(?<type>[a-z]+)(_(?<quantity>[0-9]+))*";
            var match = Regex.Match(field, pattern);
            var type = match.Groups["type"].Value;

            switch (type)
            {
                case "stone":
                case "gold":
                case "wood":
                case "food":
                    if (field == type)
                    {
                        return 1;
                    }                  
                    return int.Parse(match.Groups["quantity"].Value);
                    
                default:
                    return 0;
            }
        }

        //private static int TryGetResource(int index)
        //{
        //    string[] resourceTokens = resourceField[index].Split('_');
        //    string resource = resourceTokens[0];

        //    if (validResources.Contains(resource))
        //    {
        //        cellsVisited[index] = true;
        //        return resourceTokens.Length > 1 ? int.Parse(resourceTokens[1]) : 1;
        //    }

        //    return 0;
        //}
    }
}
