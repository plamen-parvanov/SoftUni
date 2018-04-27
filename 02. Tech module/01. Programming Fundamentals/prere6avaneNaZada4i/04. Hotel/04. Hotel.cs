using System;


namespace _04.Hotel
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;


            GetPriceForNight(month, nights, ref priceStudio, ref priceDouble, ref priceSuite);

            double totalPriceStudio = nights * priceStudio;
            double totalPriceDouble = nights * priceDouble;
            double totalPriceSuite = nights * priceSuite;

            if ((month == "October" || month == "September") && nights > 7)
            {
                totalPriceStudio -= priceStudio;
            }

            

            Console.WriteLine("Studio: {0:f2} lv.\nDouble: {1:f2} lv.\nSuite: {2:f2} lv.",
                totalPriceStudio, totalPriceDouble, totalPriceSuite);



        }

        private static void GetPriceForNight(string month, int nights, ref double priceStudio, ref double priceDouble, ref double priceSuite)
        {
            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    if (nights > 7)
                    {
                        priceStudio *= 0.95;
                    }
                    break;

                case "June":
                case "September":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    if (nights > 14)
                    {
                        priceDouble *= 0.9;
                    }
                    break;

                case "July":
                case "August":
                case "December":
                    priceStudio = 68 ;
                    priceDouble = 77;
                    priceSuite = 89;
                    if (nights > 14)
                    {
                        priceSuite *= 0.85;
                    }
                    break;


            }
        }
    }
}
