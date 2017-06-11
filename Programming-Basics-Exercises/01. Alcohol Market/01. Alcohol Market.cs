using System;


namespace _01.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWiskey = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityWiskey = double.Parse(Console.ReadLine());

            double priceRakia = 0.5 * priceWiskey;
            double priceWine = 0.6 * priceRakia;
            double priceBeer = 0.2 * priceRakia;

            double total = priceWiskey * quantityWiskey + priceBeer * quantityBeer +
                priceWine * quantityWine + priceRakia * quantityRakia;

            Console.WriteLine("{0:f2}", total);

        }
    }
}
