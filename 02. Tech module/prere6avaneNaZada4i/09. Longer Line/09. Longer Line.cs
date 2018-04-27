using System;


namespace _09.Longer_Line
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLenght = MeasureDistance(x1, y1, x2, y2);
            double secondLineLenght = MeasureDistance(x3, y3, x4, y4);

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4, firstLineLenght, secondLineLenght);

        }

        static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double firstLineLenght, double secondLineLenght)
        {
            if (firstLineLenght > secondLineLenght)
            {
                PrintLine(x1, y1, x2, y2);

            }
            else
            {
                PrintLine(x3, y3, x4, y4);
            }
        }

        static double MeasureDistance(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return lineLength;
        }

        static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double firstPoint = MeasureDistance(x1, y1, 0, 0);
            double secondPoint = MeasureDistance(x2, y2, 0, 0);
            if (firstPoint <= secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }

        }
    }
}
