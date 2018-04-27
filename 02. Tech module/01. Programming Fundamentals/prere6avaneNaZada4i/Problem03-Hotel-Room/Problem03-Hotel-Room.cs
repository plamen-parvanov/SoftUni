using System;

namespace Problem03_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 50;
            double priceApartment = 65;

            switch (month)
            {
                case "May":
                case "October":
                    if (nights > 14)
                    {
                        priceStudio *= 0.7;
                        priceApartment *= 0.9;
                    }
                    else if (nights > 7)
                    {
                        priceStudio *= 0.95;
                    }
                    break;

                case "June":
                case "September":
                    priceApartment = 68.7;
                    priceStudio = 75.2;
                    if (nights > 14)
                    {
                        priceApartment *= 0.9;
                        priceStudio *= 0.8;
                    }
                    break;

                case "July":
                case "August":
                    priceApartment = 77;
                    priceStudio = 76;
                    if (nights > 14)
                    {
                        priceApartment *= 0.9;
                    }
                    break;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", priceApartment * nights);
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio * nights);
        }
    }
}
