using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceOfHoliday = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dollsTalking = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            const double priceOfPuzzles = 2.60;
            const double priceOfDollsTalking = 3;
            const double priceOfTeddyBears = 4.10;
            const double priceOfMinions = 8.20;
            const double priceOfTrucks = 2;

            int countOfToys = puzzles + dollsTalking + teddyBears + minions + trucks;

            double priceOfToys = (puzzles * priceOfPuzzles) + (dollsTalking * priceOfDollsTalking) +
                (teddyBears * priceOfTeddyBears) + (minions * priceOfMinions) + (trucks * priceOfTrucks);

            double sum = 0;

            if (countOfToys >= 50)
            {
                priceOfToys -= priceOfToys * 0.25;
                priceOfToys -= priceOfToys * 0.10;
                sum = priceOfToys - priceOfHoliday;

                if (sum >= priceOfHoliday)
                {
                    Console.WriteLine($"Yes! {sum:F2} lv left.");
                }
                else if (sum < priceOfHoliday)
                {
                    Console.WriteLine($"Not enough money! {Math.Abs(sum):F2} lv needed.");
                }
            }
            else if (countOfToys < 50)
            {
                priceOfToys -= priceOfToys * 0.10;
                sum = priceOfToys - priceOfHoliday;

                if (sum >= priceOfHoliday)
                {

                    Console.WriteLine($"Yes! {sum:F2} lv left.");
                }
                else if (sum < priceOfHoliday)
                {
                    sum = priceOfHoliday - priceOfToys;
                    Console.WriteLine($"Not enough money! {Math.Abs(sum):F2} lv needed.");
                }

            }
        }
    }
}
