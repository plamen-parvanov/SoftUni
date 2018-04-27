using System;


namespace _13_Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            switch (figure)
            {
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    area = side * side;
                    break;

                case "rectangle":
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    area = a * b;
                    break;

                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * r * r;
                    break;

                case "triangle":
                    double sideA = double.Parse(Console.ReadLine());
                    double hA = double.Parse(Console.ReadLine());
                    area = sideA * hA / 2;
                    break;
            }
            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
