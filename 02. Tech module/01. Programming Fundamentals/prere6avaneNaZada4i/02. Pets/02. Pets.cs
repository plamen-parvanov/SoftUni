using System;


namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodHave = int.Parse(Console.ReadLine());
            double dogEatsKgPerDay = double.Parse(Console.ReadLine());
            double catEatsKgPerDay = double.Parse(Console.ReadLine());
            double turtleEatsKgPerDay = double.Parse(Console.ReadLine()) / 1000;

            double petsWillEat = days * (dogEatsKgPerDay + catEatsKgPerDay + turtleEatsKgPerDay);

            if (foodHave >= petsWillEat)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodHave - petsWillEat));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(petsWillEat - foodHave));
            }
        }
    }
}
