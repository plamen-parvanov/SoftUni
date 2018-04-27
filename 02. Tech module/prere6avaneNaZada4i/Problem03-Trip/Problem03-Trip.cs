using System;


namespace Problem03_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spends = 0;

            if (budget > 1000)
            {
                spends = 0.9 * budget;
                Console.WriteLine("Somewhere in Europe\nHotel - {0:f2}", spends);
            }
            else if (budget > 100)
            {
                switch (season)
                {
                    case "summer":
                        spends = 0.4 * budget;
                        Console.WriteLine("Somewhere in Balkans\nCamp - {0:f2}", spends);
                        break;
                    case "winter":
                        spends = 0.8 * budget;
                        Console.WriteLine("Somewhere in Balkans\nHotel - {0:f2}", spends);
                        break;
                }
            }
            else
            {
                switch (season)
                {
                   case "summer":
                        spends = 0.3 * budget;
                        Console.WriteLine("Somewhere in Bulgaria\nCamp - {0:f2}", spends);
                        break;
                    case "winter":
                        spends = 0.7 * budget;
                        Console.WriteLine("Somewhere in Bulgaria\nHotel - {0:f2}", spends);
                        break;
                }
            }
        }
    }
}
