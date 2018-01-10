namespace _03.Miles_to_Kilometers
{

    using System;


    public class Problem03
    {

        public static void Main()
        {
            // 1 mile == 1.60934 kilometers

            var miles = double.Parse(Console.ReadLine());

            var km = miles * 1.60934;

            Console.WriteLine($"{km:f2}");


        }
    }
}
