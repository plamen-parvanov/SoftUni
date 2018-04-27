namespace _07.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem07
    {
        public static void Main()
        {
            var sales = AddAllSalesFromInput();

            PrintOrdered(sales);

        }
        public static Dictionary<string, List<Sale>> AddAllSalesFromInput()
        {
            var sales = new Dictionary<string, List<Sale>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var town = inputArr[0];
                var product = inputArr[1];
                var price = double.Parse(inputArr[2]);
                var quantity = double.Parse(inputArr[3]);

                if (!sales.ContainsKey(town))
                {
                    sales[town] = new List<Sale>();
                }
                sales[town].Add(new Sale(product, price, quantity));

            }

            return sales;
        }

        public static void PrintOrdered(Dictionary<string, List<Sale>> sales)
        {
            foreach (var kvp in sales.OrderBy(x => x.Value)) // .Sum(y => y.PriceTotal)
            {                                                // ako iskam po totalSales
                var town = kvp.Key;
                var allSales = kvp.Value;
                var sum = allSales.Sum(x => x.PriceTotal);
                Console.WriteLine($"{town} -> {sum:f2}");
            }
        }
    }
}
