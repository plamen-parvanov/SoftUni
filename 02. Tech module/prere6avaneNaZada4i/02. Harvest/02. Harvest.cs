using System;


namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerMM = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double wineProduced = area * grapesPerMM * 0.4 / 2.5;
            double diff = Math.Abs(wineNeeded - wineProduced);

            if (wineNeeded > wineProduced)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", 
                    Math.Floor(diff));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                    Math.Floor(wineProduced));
                Console.WriteLine("{0} liters left -> {1} liters per person.", 
                    Math.Ceiling(diff), Math.Ceiling(diff / workers));

            }

        }
    }
}
