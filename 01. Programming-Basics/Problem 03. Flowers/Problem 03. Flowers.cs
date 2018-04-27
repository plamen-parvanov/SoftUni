using System;

namespace Problem_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var brHrizantemi = int.Parse(Console.ReadLine());
            var brRozi = int.Parse(Console.ReadLine());
            var brLaleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var praznik = Console.ReadLine().ToLower();

            var priceHrizantemi = 0.0;
            var priceRozi = 0.0;
            var priceLaleta = 0.0;
            var priceTotal = 0.0;

            if (season == "spring" || season =="summer")
            {
                priceHrizantemi = 2;
                priceRozi = 4.1;
                priceLaleta = 2.5;
            }
            else if (season == "autumn" || season == "winter")
            {
                priceHrizantemi = 3.75;
                priceRozi = 4.5;
                priceLaleta = 4.15;
            }

            priceTotal = priceHrizantemi * brHrizantemi + priceRozi * brRozi + priceLaleta * brLaleta;

            if (praznik == "y")
            {
                priceTotal *= 1.15;
            }

            if (season == "spring" && brLaleta > 7)
            {
                priceTotal *= 0.95;
            }

            if (season == "winter" && brRozi > 9)
            {
                priceTotal *= 0.9;
            }

            if (brHrizantemi + brRozi + brLaleta > 20)
            {
                priceTotal *= 0.8;
            }

            priceTotal += 2;

            Console.WriteLine("{0:f2}", priceTotal);
        }
    }
}
