namespace _02.PointInRectangle
{
    using System;
    using System.Linq;
    using Units;

    public class StartUp
    {
        public static void Main()
        {
            var rectangle = ParseRectangle(Console.ReadLine());

            CheckPoints(rectangle);
        }

        private static void CheckPoints(Rectangle rectangle)
        {
            var numberOfPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPoints; i++)
            {
                var point = ParsePoint(Console.ReadLine());

                Console.WriteLine(rectangle.Contains(point));
            }
        }

        private static Point ParsePoint(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();
            var pointX = arr[0];
            var pointY = arr[1];

            return new Point(pointX, pointY);
        }

        private static Rectangle ParseRectangle(string input)
        {
            var inputArr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            var toplLeftX = inputArr[0];
            var toplLeftY = inputArr[1];
            var bottomRightX = inputArr[2];
            var bottomRightY = inputArr[3];

            return new Rectangle(new Point(toplLeftX, toplLeftY),
                                 new Point(bottomRightX, bottomRightY));
        }
    }
}
