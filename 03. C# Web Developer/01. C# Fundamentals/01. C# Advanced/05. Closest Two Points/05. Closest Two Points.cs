namespace _05.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Problem05
    {
        public static void Main()
        {
            var points = ReadPoints();

            var closestPoints = FindClosestTwoPoins(points);

            PrintDistance(closestPoints);

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        public static List<Point> ReadPoints()
        {
            var numberOfPoints = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < numberOfPoints; i++)
            {
                points.Add(ReadPoint());
            }

            return points;
        }

        public static Point ReadPoint()
        {
            var currentLine = Console.ReadLine()
                   .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

            return new Point(currentLine[0], currentLine[1]);
        }

        public static Point[] FindClosestTwoPoins(List<Point> list)
        {
            var closestPoints = new Point[2];
            var minDistnace = double.MaxValue;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    var currDistance = CalculateDistance(list[i], list[j]);
                    if (currDistance < minDistnace)
                    {
                        minDistnace = currDistance;
                        closestPoints[0] = list[i];
                        closestPoints[1] = list[j];
                    }
                }
            }
            return closestPoints;
        }

        public static double CalculateDistance(Point first, Point second)
        {
            var x1 = first.X;
            var y1 = first.Y;
            var x2 = second.X;
            var y2 = second.Y;
            var distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return distance;
        }

        public static void PrintDistance(Point[] points)
        {
            var distance = CalculateDistance(points[0], points[1]);
            Console.WriteLine($"{distance:F3}");

        }

        public static void PrintPoint(Point point)
        {
            var x = point.X;
            var y = point.Y;
            Console.WriteLine($"({x}, {y})");
        }
    }
}
