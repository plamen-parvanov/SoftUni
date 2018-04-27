namespace _02.Parking_System
{
    using System;
    using System.Linq;

    public class Problem02
    {
        private static bool[,] matrix;

        public static void Main()
        {
            CreateMatrix();

            ReadParkingSlots();
        }

        private static void ReadParkingSlots()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "stop")
                {
                    break;
                }

                var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();
                var startRow = tokens[0];
                var desiredRow = tokens[1];
                var desiredCol = tokens[2];

                var distance = CalculateDistnece(startRow, desiredRow, desiredCol);

                var result = distance > 0 ? $"{distance}" : $"Row {desiredRow} full";

                Console.WriteLine(result);

            }
        }

        private static int CalculateDistnece(int startRow, int desiredRow, int desiredCol)
        {
            var distance = 0;

            if (IsFreeSlot(desiredRow, desiredCol))
            {
                distance = Calculate(desiredRow, startRow, desiredCol);
                matrix[desiredRow, desiredCol] = true;
                return distance;
            }

            var left = desiredCol;
            var right = desiredCol;
            var lenght = matrix.GetLength(1);

            while (left > 0 || right < lenght)
            {
                left--;
                if (IsInsideTheParkingSlot(left) && IsFreeSlot(desiredRow, left))
                {
                    distance = Calculate(desiredRow, startRow, left);
                    matrix[desiredRow, left] = true;
                    break;
                }

                right++;
                if (IsInsideTheParkingSlot(right) && IsFreeSlot(desiredRow, right))
                {
                    distance = Calculate(desiredRow, startRow, right);
                    matrix[desiredRow, right] = true;
                    break;
                }
            }

            return distance;
        }

        private static int Calculate(int desiredRow, int startRow, int desiredCol)
        {
            return Math.Abs(desiredRow - startRow) + desiredCol + 1;
        }

        private static bool IsFreeSlot(int row, int col)
        {
            return !matrix[row, col];
        }

        private static bool IsInsideTheParkingSlot(int left)
        {
            return left > 0 && left < matrix.GetLength(1);
        }

        private static void CreateMatrix()
        {
            var dimentions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            matrix = new bool[rows, cols];
        }
    }
}
