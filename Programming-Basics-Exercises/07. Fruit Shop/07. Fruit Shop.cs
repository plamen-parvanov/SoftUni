using System;


namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0.0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.5;
                            break;

                        case "apple":
                            price = 1.2;
                            break;

                        case "orange":
                            price = 0.85;
                            break;

                        case "grapefruit":
                            price = 1.45;
                            break;

                        case "kiwi":
                            price = 2.7;
                            break;

                        case "pineapple":
                            price = 5.5;
                            break;

                        case "grapes":
                            price = 3.85;
                            break;

                    default:
                         Console.WriteLine("error");
                         break;
                    }
                    Console.WriteLine("{0:F2}", price * quantity);
                    break;

                case "Sunday":
                case "Saturday":
                    switch (fruit)
                    {
                        case "banana":
                            price = 2.7;
                            break;

                        case "apple":
                            price = 1.25;
                            break;

                        case "orange":
                            price = 0.9;
                            break;

                        case "grapefruit":
                            price = 1.6;
                            break;

                        case "kiwi":
                            price = 3.0;
                            break;

                        case "pineapple":
                            price = 5.6;
                            break;

                        case "grapes":
                            price = 4.2;
                            break;

                     default:
                         Console.WriteLine("error");
                         break;
                    }
                    Console.WriteLine("{0:F2}", price * quantity);
                    break;

                default: 
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
