using System;


namespace _04.Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            bool rectangleV = (y <= 3 && y >= -5 && x >= 4 && x <= 10);
            bool rectangleH = (y >= -3 && y <= 1 && x >= 2 && x <= 12);

            if (rectangleV || rectangleH)
            {
                Console.WriteLine("in");
            }

            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
