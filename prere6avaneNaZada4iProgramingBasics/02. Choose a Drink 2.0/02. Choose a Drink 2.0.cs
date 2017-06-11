using System;


namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string drink = string.Empty;
            double price = 0;


            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.7;
                    break;

                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1;
                    break;

                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.7;
                    break;

                default:
                    drink = "Tea";
                    price = 1.2;
                    break;
            }

            double totalPrice = quantity * price;

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
