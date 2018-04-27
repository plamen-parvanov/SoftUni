namespace _03.Restaurant_Discount
{

    using System;


    public class Problem03
    {

        static int discount;

        public static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var packageType = Console.ReadLine();


            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                var hallPrice = GetPriceForHall(groupSize);

                var servicePrice = GetPriceForService(packageType);

                var bill = hallPrice + servicePrice;
                var total = bill - bill * discount / 100d;
                var totalPerPerson = total / groupSize;

                Console.WriteLine($"The price per person is {totalPerPerson:f2}$");

            }

            


        }

        public static int GetPriceForHall(int people)
        {
            var price = 7500;
            var hallName = "Great Hall";

            if (people <= 50)
            {
                hallName = "Small Hall";
                price = 2500;
            }
            else if (people <= 100)
            {
                hallName = "Terrace";
                price = 5000;
            }

            Console.WriteLine($"We can offer you the {hallName}");

            return price;
        }

        public static int GetPriceForService(string packageType)
        {
            var price = 0;

            switch (packageType)
            {
                case "Normal":
                    price = 500;
                    discount = 5;
                    break;

                case "Gold":
                    price = 750;
                    discount = 10;
                    break;

                case "Platinum":
                    price = 1000;
                    discount = 15;
                    break;
            }

            return price;
        }
    }
}
