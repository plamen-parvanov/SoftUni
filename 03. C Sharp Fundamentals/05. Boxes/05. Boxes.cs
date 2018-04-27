using System;
using System.Collections.Generic;

namespace _05.Boxes
{
    public class Problem05
    {
        static List<Box> list;

        public static void Main()
        {
            list = new List<Box>();

            ReadInput();

            PrintList();
        }

        public static void ReadInput()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "end")
                {
                    break;
                }

                AddBoxToList(inputLine);
            }
        }

        public static void AddBoxToList(string input)
        {
            var arr = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            var upperLeft = AddPoint(arr[0]);
            var upperRight = AddPoint(arr[1]);
            var bottomLeft = AddPoint(arr[2]);
            var bottomRight = AddPoint(arr[3]);

            list.Add(new Box(upperLeft, upperRight, bottomLeft, bottomRight));
        }

        public static Point AddPoint(string str)
        {
            var arr = str.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            var x = double.Parse(arr[0]);
            var y = double.Parse(arr[1]);

            return new Point(x, y);
        }

        public static void PrintList()
        {
            foreach (var box in list)
            {
                var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);
                var perimeter = Box.CalculatePerimeter(width, height);
                var area = Box.CalculateArea(width, height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
        }
    }
}
