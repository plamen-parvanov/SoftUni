using System;


namespace _04.Point_in_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (((y >= -3 && y <= 1) && x >= 2 && x <= 12) ||
                (x >= 4 && x <= 10 &&((y < -3 && y >= -5) || (y > 1 && y <= 3))))
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
