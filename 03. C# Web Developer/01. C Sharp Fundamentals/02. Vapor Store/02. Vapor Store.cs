namespace _02.Vapor_Store
{

    using System;


    public class Problem02
    {
        public static void Main()
        {

            var currBalance = float.Parse(Console.ReadLine());
            var spent = 0f;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Game Time")
                {
                    break;
                }

                var gamePrice= BuyGame(input, currBalance);
                spent += gamePrice;
                currBalance -= gamePrice;

                if (currBalance == 0f)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${currBalance:f2}");
        }

        public static float BuyGame(string input, float money)
        {
 
            var price = 0f;

            switch (input)
            {
                case "OutFall 4":
                case "RoverWatch Origins Edition":
                    price = 39.99f;
                    break;
                case "CS: OG":
                    price = 15.99f;
                    break;
                case "Zplinter Zell":
                    price = 19.99f;
                    break;
                case "Honored 2":
                    price = 59.99f;
                    break;
                case "RoverWatch":
                    price = 29.99f;
                    break;
                default:
                    Console.WriteLine("Not Found");
                    return price;
            }

            if (price > money)
            {
                Console.WriteLine("Too Expensive");
                price = 0;
            }
            else
            {
                Console.WriteLine($"Bought {input}");
            }

            return price;
        }
    }
}
