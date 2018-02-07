namespace _04.Distance_between_Points
{
    using System;
    using System.Linq;

    public class Problem04
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstPoint = new Point(firstInput[0], firstInput[1]);

            var secondInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondPoint = new Point(secondInput[0], secondInput[1]);

            var result = Point.CalculateDistenceBetweenTwoPoints(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");

        }
    }
}
