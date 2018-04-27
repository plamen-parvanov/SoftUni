using System;


namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool workdays;
            double price = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    workdays = true;
                    break;
                case "Saturday":
                case "Sunday":
                    workdays = false;
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
            switch (fruit)
            {
                case "banana":
                    price = workdays ? 2.5 : 2.7;
                    break;
                case "apple":
                    price = workdays ? 1.2 : 1.25;
                    break;
                case "orange":
                    price = workdays ? 0.85 : 0.9;
                    break;
                case "grapefruit":
                    price = workdays ? 1.45 : 1.6;
                    break;
                case "kiwi":
                    price = workdays ? 2.7 : 3;
                    break;
                case "pineapple":
                    price = workdays ? 5.5 : 5.6;
                    break;
                case "grapes":
                    price = workdays ? 3.85 : 4.2;
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
            Console.WriteLine("{0:f2}", price * quantity);

        }
    }
}
