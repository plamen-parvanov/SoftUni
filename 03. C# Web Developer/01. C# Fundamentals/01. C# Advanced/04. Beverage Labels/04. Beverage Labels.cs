namespace _04.Beverage_Labels
{

    using System;


    public class Problem04
    {

        public static void Main()
        {

            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            var totalEnergy = volume * energyPer100ml / 100d;
            var totalSugar = volume * sugarPer100ml / 100d;

            Console.WriteLine($"{volume}ml {name}:\r{totalEnergy}kcal, {totalSugar}g sugars");


        }
    }
}
