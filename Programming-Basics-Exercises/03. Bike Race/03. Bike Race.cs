using System;


namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var track = Console.ReadLine().ToLower();
            var priceJ = 0.0;
            var priceS = 0.0;
            var income = 0.0;

            if (track == "trail")
            {
                priceJ = 5.5;
                priceS = 7;
            }

            else if (track == "cross-country")
            {
                priceJ = 8;
                priceS = 9.5;

                if (juniors + seniors >= 50)
                {
                    priceJ *= 0.75;
                    priceS *= 0.75;
                }
            }

            else if (track == "downhill")
            {
                priceJ = 12.25;
                priceS = 13.75;
            }

            else if (track == "road")
            {
                priceJ = 20;
                priceS = 21.5;
            }

            

            income = priceJ * juniors + priceS * seniors;
            income *= 0.95;

            Console.WriteLine("{0:f2}", income);
        }
    }
}
