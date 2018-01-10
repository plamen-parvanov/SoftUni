namespace _05.Distance_of_the_Stars
{

    using System;


    public class Problem05
    {

        public static void Main()
        {
            // 9 450 000 000 000 km = 1 ly
            // 4.22 ly , 26 000 ly , 100 000 ly , 46 500 000 000 ly 

            var firstDistInLy = 4.22m;
            var secondDistInLy = 26000m;
            var thirdDistInLy = 100000m;
            var forthDistInLy = 46500000000m;
            var lyInKm = 9450000000000;

            var firstDistInKm = firstDistInLy * lyInKm;
            var secondDistInKm = secondDistInLy * lyInKm;
            var thirdDistInKM = thirdDistInLy * lyInKm;
            var forthDistInKm = forthDistInLy * lyInKm;

            Console.WriteLine($"{firstDistInKm:e2}");
            Console.WriteLine($"{secondDistInKm:e2}");
            Console.WriteLine($"{thirdDistInKM:e2}");
            Console.WriteLine($"{forthDistInKm:e2}");




        }
    }
}
