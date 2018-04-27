using System;


namespace Problem_03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());
            var pricePerKm = 0.0;
            var wageWithoutTax = 0.0;

            if (kmPerMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.75;
                        break;

                    case "Summer":
                        pricePerKm = 0.9;
                        break;

                    case "Winter":
                        pricePerKm = 1.05;
                        break;
                }
                wageWithoutTax = 4 *pricePerKm * kmPerMonth - (4 * 0.1 * pricePerKm * kmPerMonth);
                Console.WriteLine("{0:F2}", wageWithoutTax);
            }

            else if (kmPerMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.95;
                        break;

                    case "Summer":
                        pricePerKm = 1.1;
                        break;

                    case "Winter":
                        pricePerKm = 1.25;
                        break;
                }
                wageWithoutTax = 4 * pricePerKm * kmPerMonth - (4 * 0.1 * pricePerKm * kmPerMonth);
                Console.WriteLine("{0:F2}", wageWithoutTax);
            }

            else if (kmPerMonth <= 20000)
            { 
                        pricePerKm = 1.45;
                      
                wageWithoutTax = 4 *pricePerKm * kmPerMonth - (4 * 0.1 * pricePerKm * kmPerMonth);
                Console.WriteLine("{0:F2}", wageWithoutTax);
            }
        }
    }
}
