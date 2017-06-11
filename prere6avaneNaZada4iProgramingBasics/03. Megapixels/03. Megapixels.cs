using System;


namespace _03.Megapixels
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double resultInMgP = Math.Round(width / 1000d * height / 1000d, 1);

            Console.WriteLine("{0}x{1} => {2}MP", width, height, resultInMgP);
        }
    }
}
