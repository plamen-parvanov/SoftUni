using System;
using System.Collections.Generic;
using System.Linq;

public class RectangleIntersection
{
    static void Main()
    {
        var inputArr = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var rectangleNum = inputArr[0];
        var rectangles = AddAllRectangles(rectangleNum);

        var checksNum = inputArr[1];
        MakeAllChecks(checksNum, rectangles);
    }

    private static void MakeAllChecks(int checksNum, List<Rectangle> rectangles)
    {
        for (int i = 0; i < checksNum; i++)
        {
            var currPairToCheck = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstRectangle = GetREctangle(rectangles, currPairToCheck[0]);

            var secondRectangle = GetREctangle(rectangles, currPairToCheck[1]);

            if (firstRectangle.CheckIfRectanglesIntersect(secondRectangle))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }

    private static Rectangle GetREctangle(List<Rectangle> rectangles, string rectId)
    {
        return rectangles.Where(r => r.id == rectId).First();
    }

    private static List<Rectangle> AddAllRectangles(int num)
    {
        var rectangles = new List<Rectangle>(num);

        for (int i = 0; i < num; i++)
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var id = inputLine[0];
            var width = double.Parse(inputLine[1]);
            var height = double.Parse(inputLine[2]);
            var topLeftX = double.Parse(inputLine[3]);
            var topLeftY = double.Parse(inputLine[4]);

            rectangles.Add(new Rectangle(id, width, height, topLeftX, topLeftY));
        }

        return rectangles;
    }
}
