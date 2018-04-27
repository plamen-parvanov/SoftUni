namespace _04.Most_Valued_Customer
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem04
    {

        static Dictionary<string, double> prices;
        static Dictionary<string, Dictionary<string, byte>> customers;
        static double biggestTotal;
        public static void Main()
        {
            prices = new Dictionary<string, double>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Shop is open")
                {
                    break;
                }

                AddPriceForProducts(inputLine);
            }

            customers = new Dictionary<string, Dictionary<string, byte>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Print")
                {
                    break;
                }
                else if (inputLine == "Discount")
                {
                    MakeDiscount();
                }
                else
                {
                    AddProductsToCustomers(inputLine);
                }

            }

            var biggestSpender = GetNameOfBiggestSpender();

            Print(biggestSpender);
        }

        public static void AddPriceForProducts(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var product = inputArr[0];
            var price = double.Parse(inputArr[1]);

            prices[product] = price;
        }

        public static void MakeDiscount()
        {
            foreach (var kvp in prices.OrderByDescending(v => v.Value).Take(3))
            {
                var key = kvp.Key;
                prices[key] *= 0.9; 
            }

        }

        public static void AddProductsToCustomers(string input)
        {
            var inputArr = input.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
            var customer = inputArr[0];

            if (!customers.ContainsKey(customer))
            {
                customers[customer] = new Dictionary<string, byte>();
            }

            var products = inputArr[1]
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var specialProduct = string.Empty;
            var cntr = 0;

            foreach (var product in products)
            {
                if (!customers[customer].ContainsKey(product) && prices.ContainsKey(product))
                {
                    customers[customer][product] = 1;
                }
                else if(prices.ContainsKey(product) && (cntr == 0 || product == specialProduct))
                {
                    customers[customer][product]++;
                    specialProduct = product;
                    cntr++;
                }
            }

        }

        public static string GetNameOfBiggestSpender()
        {
            var biggest = string.Empty;
            biggestTotal = 0d;

            foreach (var customer in customers)
            {
                var currName = customer.Key;
                var currTotal = 0d;

                foreach (var product in customer.Value)
                {
                    var name = product.Key;
                    var quantity = product.Value;
                    var price = prices[name];
                    currTotal += (price * quantity);
                }

                if (currTotal > biggestTotal)
                {
                    biggestTotal = currTotal;
                    biggest = currName;
                }
            }

            return biggest;
        }

        public static void Print(string customer)
        {
            Console.WriteLine($"Biggest spender: {customer}");
            Console.WriteLine("^Products bought:");
            foreach (var product in customers[customer].OrderByDescending(p => prices[p.Key]))
            {
                var name = product.Key;
                var price = prices[name];
                Console.WriteLine($"^^^{name}: {price:f2}" );
            }
            Console.WriteLine($"Total: {biggestTotal:f2}");
        }
    }
}
