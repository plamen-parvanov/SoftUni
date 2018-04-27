using System;
using System.Linq;

namespace _06.Rectangle_Position
{
    public class Problem06
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var isFirstInsideSecond = CalculateIsFirstRectInsideTheSecond(firstRectangle, secondRectangle);

            Print(isFirstInsideSecond);
        }

        public static Rectangle ReadRectangle()
        {
            var inputArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var width = inputArr[2];
            var height = inputArr[3];

            var leftBottom = new Point(inputArr[0], inputArr[1]);
            var leftTop = new Point(leftBottom.X, leftBottom.Y + height);
            var rightBottom = new Point(leftBottom.X + width, leftBottom.Y);
            var rightTop = new Point(rightBottom.X, leftTop.Y);

            return new Rectangle(leftBottom, leftTop, rightBottom, rightTop);
        }

        public static bool CalculateIsFirstRectInsideTheSecond(Rectangle first, Rectangle second)
        {
            var leftBottomPointIsInside = CalculateIsPointInsideRectangle(first.LeftBottom, second);
            var leftTopPointIsInside = CalculateIsPointInsideRectangle(first.LeftTop, second);
            var rightBottomPointIsInside = CalculateIsPointInsideRectangle(first.RightBottom, second);
            var rightTopPointIsInside = CalculateIsPointInsideRectangle(first.RightTop, second);

            if (leftBottomPointIsInside && leftTopPointIsInside 
                && rightBottomPointIsInside && rightTopPointIsInside)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CalculateIsPointInsideRectangle(Point point, Rectangle rectangle)
        {
            if (point.X >= rectangle.LeftBottom.X && point.X <= rectangle.RightBottom.X &&
                point.Y >= rectangle.LeftBottom.Y && point.Y <= rectangle.RightTop.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Print(bool isInside)
        {
            Console.WriteLine(isInside ? "Inside" : "Not inside");
        }
    }
}
