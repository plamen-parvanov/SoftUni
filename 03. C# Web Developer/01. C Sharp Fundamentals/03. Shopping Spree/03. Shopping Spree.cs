namespace _03.Shopping_Spree
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem
    {
        public static void Main()
        {
            var budget = decimal.Parse(Console.ReadLine());
            var dict = new Dictionary<string, decimal>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = arr[0];
                var price = decimal.Parse(arr[1]);

                if (!dict.ContainsKey(product) || price < dict[product])
                {
                    dict[product] = price;
                }
            }

            var priceAllProducts = dict.Values.Sum();

            if (priceAllProducts > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                    dict
                    .OrderByDescending(v => v.Value)
                    .ThenBy(k => k.Key.Length)
                    .ToDictionary(k => k.Key, v => v.Value)
                    .Keys.Select(k => string.Format("{0} costs {1:f2}", k, dict[k]))));
            }
        }
    }
}
