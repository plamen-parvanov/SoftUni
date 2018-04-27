using System;


namespace _01.Impress_the_girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceInRubles = double.Parse(Console.ReadLine());
            double priceInDollars = double.Parse(Console.ReadLine());
            double priceInEuro = double.Parse(Console.ReadLine());
            double priceInLevaForTwo = double.Parse(Console.ReadLine());
            double priceInLeva = double.Parse(Console.ReadLine());
            double rublesInLeva = priceInRubles * 3.5 / 100;
            double dollarsInLeva = priceInDollars * 1.5;
            double euroInLeva = priceInEuro * 1.95;
            double priceForOne = priceInLevaForTwo / 2.0;
            double mostExpensive = 0.0;
            if (rublesInLeva > mostExpensive)
            {
                mostExpensive = rublesInLeva;
            }
            if (dollarsInLeva > mostExpensive)
            {
                mostExpensive = dollarsInLeva;
            }
            if (euroInLeva > mostExpensive)
            {
                mostExpensive = euroInLeva;
            }
            if (priceForOne > mostExpensive)
            {
                mostExpensive = priceForOne;
            }
            if (priceInLeva > mostExpensive)
            {
                mostExpensive = priceInLeva;
            }

            Console.WriteLine("{0:f2}", Math.Ceiling(mostExpensive)); //{0:0.00}
            // moje is s Math.Max()
        }
    }
}
