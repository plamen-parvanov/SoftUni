namespace _06.CottageScraper
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem05
    {

        public static void Main()
        {
            var dict = new Dictionary<string, List<double>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "chop chop")
                {
                    break;
                }

                AddTreeIn(dict, input);
            }

            var neededType = Console.ReadLine();
            var minLenght = double.Parse(Console.ReadLine());

            //Price per meter == (sum of all logs) / (count) 
            var allLogsLenght = dict.Sum(v => v.Value.Sum());
            var pricePerMeter =  Math.Round(allLogsLenght / dict.Sum(v => v.Value.Count), 2);
            var usedLogLenght = dict[neededType].Where(v => v >= minLenght).Sum();
            var usedLogPrice = Math.Round(usedLogLenght * pricePerMeter, 2);
            var unusedLogPrice = Math.Round((allLogsLenght - usedLogLenght) * 0.25 * pricePerMeter, 2);
            var totalPrice = Math.Round(usedLogPrice + unusedLogPrice, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
        }

        public static void AddTreeIn(Dictionary<string, List<double>>dict, string input)
        {
            var arr = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            var type = arr[0];
            var quantity = double.Parse(arr[1]);

            if (!dict.ContainsKey(type))
            {
                dict[type] = new List<double>();
            }

            dict[type].Add(quantity);
        }
    }
}
