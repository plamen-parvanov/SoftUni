using System;


namespace _08.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = side * h / 2;
            Console.WriteLine("Triangle Area = {0}", Math.Round(area, 2));
        }
    }
}
