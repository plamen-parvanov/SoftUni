using System;


namespace _02.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            double puzzleSold = double.Parse(Console.ReadLine());
            double puppetsSold = double.Parse(Console.ReadLine());
            double bearsSold = double.Parse(Console.ReadLine()); 
            double minionsSold = double.Parse(Console.ReadLine());
            double truckSold = double.Parse(Console.ReadLine());

            double puzzleIncome = 2.6 * puzzleSold;
            double puppetsIncome = 3 * puppetsSold;
            double bearsIncome = 4.1 * bearsSold;
            double minionsIncome = 8.2 * minionsSold;
            double truckIncome = 2 * truckSold;

            double total = puzzleIncome + puppetsIncome + bearsIncome + minionsIncome + truckIncome;


            if (puppetsSold + puppetsSold + bearsSold + minionsSold + truckSold >= 50)
            {
                total *= 0.75;
            }

            total *= 0.9;

            if (total >= trip)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", total - trip);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", trip - total);
            }

        }
    }
}
