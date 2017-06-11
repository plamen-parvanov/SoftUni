using System;


namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceSkumriq = double.Parse(Console.ReadLine());
            var priceCaca = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgMidi = double.Parse(Console.ReadLine());

            var money = kgPalamud * (priceSkumriq + 0.6 * priceSkumriq)
                + kgSafrid * (priceCaca + 0.8 * priceCaca)
                + kgMidi * 7.5;

            Console.WriteLine("{0:F2}" , money);
        }
    }
}
