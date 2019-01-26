namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Rectangle> rectangles;
        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var numberOfRectangles = inputArr[0];

            AddRectangles(numberOfRectangles);

            var numerOfChecks = inputArr[1];

            MakeIntersectionChecks(numerOfChecks);

        }

        private static void MakeIntersectionChecks(int numberOfChecks)
        {
            for (int i = 0; i < numberOfChecks; i++)
            {
                var inputArr = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var firstRectangleId = inputArr[0];
                var firstRectangle = GetRectangle(firstRectangleId);

                var secondRectangleId = inputArr[1];
                var secondRectangle = GetRectangle(secondRectangleId);

                PrintCheckResult(firstRectangle, secondRectangle);
            }
        }

        private static void PrintCheckResult(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            var result = string.Empty;

            if (firstRectangle.IsRectangleIntersectWith(secondRectangle))
            {
                result = "true";
            }
            else
            {
                result = "false";
            }

            Console.WriteLine(result);
        }

        private static Rectangle GetRectangle(string rectangleId)
        {
            return rectangles.FirstOrDefault(r => r.Id == rectangleId);
        }

        private static void AddRectangles(int numberOfRectangles)
        {
            rectangles = new List<Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var currRectangle = ReadRectangle();

                rectangles.Add(currRectangle);
            }
        }

        private static Rectangle ReadRectangle()
        {
            var inputArr = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var id = inputArr[0];
            var width = double.Parse(inputArr[1]);
            var height = double.Parse(inputArr[2]);
            var topLeftCorner = new Point(double.Parse(inputArr[3]), double.Parse(inputArr[4]));

            return new Rectangle(id, width, height, topLeftCorner);
        }
    }
}
