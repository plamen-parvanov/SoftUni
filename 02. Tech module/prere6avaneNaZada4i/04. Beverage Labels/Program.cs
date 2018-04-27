using System;


namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfProduct = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyCnt = double.Parse(Console.ReadLine()) * volume / 100;
            double sugarCnt = double.Parse(Console.ReadLine()) * volume / 100;

            Console.WriteLine($"{volume}ml {nameOfProduct}: \n{energyCnt}kcal, {sugarCnt}g sugars");

        }
    }
}
