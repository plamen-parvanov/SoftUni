using System;


namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x > 0 && x < 3 * h) && (y > 0 && y < h) || 
                (x > h && x < 2 * h) && (y >= h && y < 4 * h))
            {
                Console.WriteLine("inside");
            }
            else if ((y ==0 && (x >= 0 && x <= 3 * h)) ||
                ((x == 0 || x == 3 * h) && (y > 0 && y <= h)) ||
                (y == h && ((x > 0 && x <= h) || (x >= 2 * h && x < 3 * h))) ||
                ((x == h || x == 2 * h) && (y > h && y <= 4 * h)) ||
                (y == 4 * h && (x > h && x < 2 * h)))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
