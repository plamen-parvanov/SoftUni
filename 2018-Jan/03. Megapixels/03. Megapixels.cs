namespace _03.Megapixels
{

    using System;


    public class Problem03
    {
        public static void Main()
        {

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var result = width * height / 1000000d;

            Console.WriteLine("{0}x{1} => {2}MP", width, height, Math.Round(result, 1));

        }
    }
}
