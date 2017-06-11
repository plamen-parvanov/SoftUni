using System;


namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main()
        {
            string figureType = Console.ReadLine();

            double area = CalculatAreaOfInputFigure(figureType);

            Console.WriteLine("{0:F2}", area);
        }

        static double CalculatAreaOfInputFigure(string figureType)
        {
            double area = 0;
            switch (figureType)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = CalculateAreaOfTriangle(sideTriangle, height);
                    break;

                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    area = CalculateAreaOfSquare(sideSquare);
                    break;

                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRec = double.Parse(Console.ReadLine());
                    area = CalculateAreaOfRectangle(width, heightRec);
                    break;

                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = CalculateAreaOfCircle(radius);
                    break;
            }

            return area;
        }

        static double CalculateAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        static double CalculateAreaOfRectangle(double width, double heightRec)
        {
            double area = width * heightRec;
            return area; 
        }

        static double CalculateAreaOfSquare(double side)
        {
            double area = side * side;
            return area;
        }

        static double CalculateAreaOfTriangle(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
    }
}
