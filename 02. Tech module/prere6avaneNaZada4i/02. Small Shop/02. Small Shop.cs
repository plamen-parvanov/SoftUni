using System;


namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //         coffee 	water	beer	sweets	peanuts
            //  Sofia   0.50    0.80    1.20    1.45    1.60

           

            
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double priceCoffe = 0;
            double priceWater = 0;
            double priceBeer = 0;
            double priceSweets = 0;
            double pricePeanuts = 0;
            double productPrice = 0;


            if (town == "Sofia")
            {
                priceCoffe = 0.5;
                priceWater = 0.8;
                priceBeer = 1.2;
                priceSweets = 1.45;
                pricePeanuts = 1.6;
            }
            else if (town == "Plovdiv") //  Plovdiv 0.40    0.70    1.15    1.30    1.50
            {
                priceCoffe = 0.4;
                priceWater = 0.7;
                priceBeer = 1.15;
                priceSweets = 1.3;
                pricePeanuts = 1.5;                
            }
            else if (town == "Varna")  //  Varna   0.45    0.70    1.10    1.35    1.55
            {
                priceCoffe = 0.45;
                priceWater = 0.7;
                priceBeer = 1.1;
                priceSweets = 1.35;
                pricePeanuts = 1.55;
            }

            if (product == "coffee")
            {
                productPrice = priceCoffe; 
            }
            else if (product == "water")
            {
                productPrice = priceWater;
            }
            else if (product == "beer")
            {
                productPrice = priceBeer;
            }
            else if (product == "sweets")
            {
                productPrice = priceSweets;
            }
            else if (product == "peanuts")
            {
                productPrice = pricePeanuts;
            }

            Console.WriteLine("{0}", productPrice * quantity);
        }

    }
}
