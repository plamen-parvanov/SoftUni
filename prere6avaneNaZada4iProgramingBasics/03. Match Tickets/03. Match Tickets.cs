using System;


namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string cathegory = Console.ReadLine();
            double people = double.Parse(Console.ReadLine());
            double ticketPrice = 0;
            

            if (people >= 50)
            {
                budget *= 0.75; 
            }
            else if (people >= 25)
            {
                budget *= 0.6;
            }
            else if (people >= 10)
            {
                budget *= 0.5;
            }
            else if (people >= 5)
            {
                budget *= 0.4;
            }
            else
            {
                budget *= 0.25;
            }

            switch (cathegory)
            {
                case "VIP":
                    ticketPrice = 499.99;
                    break;
                case "Normal":
                    ticketPrice = 249.99;
                    break;
            }
            double diff = budget - people * ticketPrice;

            if (diff >= 0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", diff);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(diff));
            }
        }
    }
}
