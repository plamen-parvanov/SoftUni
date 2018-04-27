namespace _07.Training_Hall_Equipment
{

    using System;


    public class Problem07
    {
        public static void Main()
        {

            var budget = decimal.Parse(Console.ReadLine());
            var numberOfItems = byte.Parse(Console.ReadLine());
            var chart = 0m;

            for (int i = 0; i < numberOfItems; i++)
            {
                var item = Console.ReadLine();
                var price = decimal.Parse(Console.ReadLine());
                var count = short.Parse(Console.ReadLine());

                Console.WriteLine("Adding {0} {1}{2} to cart.",count, item, count == 1 ? "" : "s");

                chart += count * price;
            }

            Console.WriteLine($"Subtotal: ${chart:f2}");

            if (budget >= chart)
            {
                Console.WriteLine($"Money left: ${budget - chart:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${chart - budget:f2} more."); 
            }

        }
    }
}
