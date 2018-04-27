namespace _03.Circles_Intersection
{
    using System;
    using System.Linq;

  
    public class ObjectsAndClasses
    {

        public static void Main()
        {

            var firstPoint = AddingPointInfo();
            var secondPoint = AddingPointInfo();

            var distance = CalcDistBetweenPoints(firstPoint, secondPoint);

            var firstPointRadius = firstPoint.radius;
            var secondPointRadius = secondPoint.radius;

            var isIntersection = 
                distance <= firstPointRadius + secondPointRadius ? "Yes" : "No";

            Console.WriteLine(isIntersection);
            
        }

        public static Point AddingPointInfo()
        {
            var inputLine = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var point = new Point();
            point.X = inputLine[0];
            point.Y = inputLine[1];
            point.radius = inputLine[2];

            return point;
        }

        public static double CalcDistBetweenPoints(Point firstPoint, Point secondPoint)
        {
            var x1 = firstPoint.X;
            var x2 = secondPoint.X;
            var y1 = firstPoint.Y;
            var y2 = secondPoint.Y;

            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;

        }
    }
}
