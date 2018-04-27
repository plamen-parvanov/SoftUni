using System;


namespace _01.The_Better_Music_Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldInEurope = int.Parse(Console.ReadLine());
            decimal priceInEuro = decimal.Parse(Console.ReadLine());
            int soldInNAmerica = int.Parse(Console.ReadLine());
            decimal priceInUSD = decimal.Parse(Console.ReadLine());
            int soldInSAmerika = int.Parse(Console.ReadLine());
            decimal priceInPesos = decimal.Parse(Console.ReadLine());
            int concerts = int.Parse(Console.ReadLine());
            decimal pricePerConcert = decimal.Parse(Console.ReadLine());

            decimal profitFromAlbums = soldInEurope * priceInEuro * 1.94m
                + soldInNAmerica * priceInUSD * 1.72m
                + soldInSAmerika * priceInPesos / 332.74m;
            profitFromAlbums *= 0.65m;
            profitFromAlbums *= 0.8m;

            decimal profitFromConcerts = concerts * pricePerConcert * 1.94m;
            if (profitFromConcerts > 100000)
            {
                profitFromConcerts *= 0.85m;
            }

            if (profitFromAlbums > profitFromConcerts)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", profitFromAlbums);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", profitFromConcerts);
            }

        }
    }
}
