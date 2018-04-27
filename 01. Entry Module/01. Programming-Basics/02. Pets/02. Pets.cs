using System;


namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var allFood = double.Parse(Console.ReadLine());
            var dogKgPerDay = double.Parse(Console.ReadLine());
            var catKgPerDay = double.Parse(Console.ReadLine());
            var turGrPerDay = double.Parse(Console.ReadLine());

            var dogEats = days * dogKgPerDay;
            var catEats = days * catKgPerDay;
            var turEats = days * turGrPerDay / 1000;
            var animalsEat = dogEats + catEats + turEats;
            var foodDif = Math.Abs(allFood - animalsEat);

            if (allFood >= animalsEat)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodDif));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodDif));
            }

        }
    }
}
