namespace _05.Calculate_Triangle_Area
{

    using System;


    public class Problem05
    {

        public static void Main()
        {

            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = CalculateTriangleArea(width, height);

            Console.WriteLine(area);
        }

        public static double CalculateTriangleArea(double w, double h)
        {
            return w * h / 2;
        }
    }
}
