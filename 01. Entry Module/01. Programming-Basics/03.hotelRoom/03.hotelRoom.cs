using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var priceApartment = 0d;
            var priceStudio = 0d;
            var discountApartment = 0d;
            var discountStudio = 0d;

            if (month == "May" || month == "October") 
            {
                priceApartment = 65;
                priceStudio = 50;

                if (nights > 14)
                {
                    discountApartment += 0.10;
                    discountStudio +=0.30;   
                }

                else if (nights > 7)
                {
                    discountStudio += 0.05;  
                } 
            }

            if (month == "June" || month == "September")
            {
                priceApartment = 68.70;
                priceStudio = 75.20;

                if (nights > 14)
                {
                    discountApartment += 0.10;
                    discountStudio += 0.20;    
                }  
            }

            if (month == "July" || month == "August")
            {
                priceApartment = 77;
                priceStudio = 76;

                if (nights > 14)
                {
                    discountApartment += 0.10;
                }  
            }

            Console.WriteLine("Apartment: {0:F2} lv.",
                        nights * (priceApartment - priceApartment * discountApartment));
            Console.WriteLine("Studio: {0:F2} lv.",
                nights * (priceStudio - priceStudio * discountStudio));
        }
    }
}
