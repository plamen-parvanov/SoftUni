namespace _04.Supermarket_Database
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Dictionaries
    {

        public static void Main()
        {
            var inputLine = Console.ReadLine().Split().ToArray();

            var database = AddingProductPriceAndQuantity(inputLine);

            var grandTotal = 0d;

            foreach (var product in database)
            {
                var name = product.Key;
                var price = product.Value.Keys.Last();
                var quantity = product.Value.Values.Sum();
                grandTotal += price * quantity;

                Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}",
                    name, price, quantity, price * quantity);
            }

            Console.WriteLine(new string('-', 30)); 
            Console.WriteLine("Grand Total: ${0:f2}", grandTotal);
           

           
        }

        public static Dictionary<string, Dictionary<double, int>> 
            AddingProductPriceAndQuantity(string[] inputLine)
        {
            var database = new Dictionary<string, Dictionary<double, int>>();

            while (!inputLine[0].Equals("stocked"))
            {
                var product = inputLine[0];
                var price = double.Parse(inputLine[1]);
                var quantity = int.Parse(inputLine[2]);

                if (!database.ContainsKey(product))
                {
                    database[product] = new Dictionary<double, int>();
                }

                if (! database[product].ContainsKey(price))
                {
                    database[product][price] = 0;
                }

                database[product][price] += quantity;

                inputLine = Console.ReadLine().Split().ToArray();
            }

            return database;
        }
    }
}
