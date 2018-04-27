using System;


namespace _02.Vapor_Store
{
    class Program
    {
        static void Main()
        {
            double currBalance = double.Parse(Console.ReadLine());
            string input = string.Empty;
            double price = 0;
            double spent = 0;

            do
            {
                input = Console.ReadLine();
                if (input == "Game Time")
                {
                    break;
                }
                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        price = 0;
                        break;

                }
                if (price == 0)
                {
                    Console.WriteLine("Not Found");
                }
                else if (currBalance >= price)
                {
                    Console.WriteLine($"Bought {input}");
                    currBalance -= price;
                    spent += price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (currBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

            }
            while (true);

            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${currBalance:f2}");

        }


    }
}
