using System;


namespace _08.Center_Point
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstPointToCenter = GetDistenceFromPointToCenter(x1, y1);
            double secondPointToCenter = GetDistenceFromPointToCenter(x2, y2);

            PrintClosestPointToCenter(x1, y1, x2, y2, firstPointToCenter, secondPointToCenter);

        }

        static void PrintClosestPointToCenter(double x1, double y1, double x2, double y2, 
            double firstPointToCenter, double secondPointToCenter)
        {
            if (firstPointToCenter < secondPointToCenter)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }

        }

       
        static double GetDistenceFromPointToCenter(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(0 - x1, 2) + Math.Pow(0 - y1, 2));
            return distance;
        }
    }
}
