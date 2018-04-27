using System;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = string.Empty;
            double priceForHall = 0;
            priceForHall = GetPriceForHall(groupSize, priceForHall, ref hallName);

            if (groupSize > 120)
            {
                return;
            }
            double priceForService = 0;
            double discount = 0;
            GetPriceForPackage(package, ref priceForService, ref discount);

            double totalPrice = priceForHall + priceForService;
            totalPrice *= (1 - discount);

            double pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");



        }

        private static void GetPriceForPackage(string package, ref double priceForService, ref double discount)
        {
            switch (package)
            {
                case "Normal":
                    priceForService = 500;
                    discount = 0.05;
                    break;

                case "Gold":
                    priceForService = 750;
                    discount = 0.1;
                    break;

                case "Platinum":
                    priceForService = 1000;
                    discount = 0.15;
                    break;
            }
        }

        private static double GetPriceForHall(int groupSize, double priceForHall, ref string hallName)
        {
            if (groupSize < 51)
            {
                hallName = "Small Hall";
                priceForHall = 2500;
            }
            else if (groupSize < 101)
            {
                hallName = "Terrace";
                priceForHall = 5000;
            }
            else if (groupSize < 121)
            {
                hallName = "Great Hall";
                priceForHall = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");               
            }

            return priceForHall;
        }
    }
}
