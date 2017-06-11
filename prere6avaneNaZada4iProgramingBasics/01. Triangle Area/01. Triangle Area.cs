using System;


namespace _01.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int sideA = x3 - x2;
            int ha = y2 - y1;
            double S = Math.Abs(sideA * ha / 2d);

            Console.WriteLine(S);
        }
    }
}
