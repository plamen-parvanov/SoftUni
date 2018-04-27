using System;

namespace _08.second_way
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPointToCenter(x1, y1, x2, y2);

        }

        static void PrintClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            double closestPointToCenterX = x2;
            double closestPointToCenterY = y2;

            FindTheClosestPointToCenter(x1, y1, x2, y2,
            ref closestPointToCenterX, ref closestPointToCenterY);

            Console.WriteLine("({0}, {1})", closestPointToCenterX, closestPointToCenterY);
        }

        static void FindTheClosestPointToCenter(double x1, double y1, double x2, double y2,
            ref double closestPointToCenterX, ref double closestPointToCenterY)
        {
            double firstPointToCenter = GetDistenceFromPointToCenter(x1, y1);
            double secondPointToCenter = GetDistenceFromPointToCenter(x2, y2);


            if (firstPointToCenter < secondPointToCenter)
            {
                closestPointToCenterX = x1;
                closestPointToCenterY = y1;
            }

        }

        static double GetDistenceFromPointToCenter(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(0 - x1, 2) + Math.Pow(0 - y1, 2));
            return distance;
        }
    }
}
