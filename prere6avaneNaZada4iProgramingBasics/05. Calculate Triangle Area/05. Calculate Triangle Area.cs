using System;


namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width, heigth);
            Console.WriteLine(area);
        }
        static double CalculateTriangleArea(double width, double heigth)
        {
            double result = width * heigth / 2;
            return result;
        }
    }
}
