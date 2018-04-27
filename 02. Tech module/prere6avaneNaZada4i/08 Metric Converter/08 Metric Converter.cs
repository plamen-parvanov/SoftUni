using System;


namespace _08_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine();
            string secondMetric = Console.ReadLine();
            double m = 1;
            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            double koef1 = 0;
            double koef2 = 0;

            switch (firstMetric)
            {
                case "m":
                    koef1 = m;
                    break;
                case "mm":
                    koef1 = mm;
                    break;
                case "cm":
                    koef1 = cm;
                    break;
                case "mi":
                    koef1 = mi;
                    break;
                case "in":
                    koef1 = inch;
                    break;
                case "km":
                    koef1 = km;
                    break;
                case "ft":
                    koef1 = ft;
                    break;
                case "yd":
                    koef1 = yd;
                    break;
            }

            switch (secondMetric)
            {
                case "m":
                    koef2 = m;
                    break;
                case "mm":
                    koef2 = mm;
                    break;
                case "cm":
                    koef2 = cm;
                    break;
                case "mi":
                    koef2 = mi;
                    break;
                case "in":
                    koef2 = inch;
                    break;
                case "km":
                    koef2 = km;
                    break;
                case "ft":
                    koef2 = ft;
                    break;
                case "yd":
                    koef2 = yd;
                    break;
            }
            Console.WriteLine( num * koef2 / koef1);
        }
    }
}
