using System;


namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            double bill = 0;

            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    itemName += "s";
                }

                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");

                bill += itemCount * itemPrice;
                


            }

            Console.WriteLine($"Subtotal: ${bill:f2}");

            if (budget >= bill)
            {
                Console.WriteLine("Money left: ${0:f2}", budget - bill);
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.", bill - budget);
            }
        }
    }
}
