using System;


namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriq = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            double pricePalamud = 1.6 * priceSkumriq * kgPalamud;
            double priceSafrid = 1.8 * priceCaca * kgSafrid;
            double priceMidi = 7.5 * kgMidi;

            Console.WriteLine("{0:f2}", pricePalamud + priceSafrid + priceMidi);
        }
    }
}
