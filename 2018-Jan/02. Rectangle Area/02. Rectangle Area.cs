namespace _02.Rectangle_Area
{

    using System;


    public class Problem02
    {

        public static void Main()
        {

            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;

            Console.WriteLine($"{area:f2}");

        }
    }
}
