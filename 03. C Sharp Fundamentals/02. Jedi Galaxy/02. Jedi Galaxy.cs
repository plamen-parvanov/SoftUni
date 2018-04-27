namespace _02.Jedi_Galaxy
{
    using System;
    using System.Linq;

    public class Problem02
    {
        private static int[,] matrix;
        public static void Main()
        {
            CreateMatrix();

            FillMatrix();

            var result = CollectStars();

            Console.WriteLine(result);
        }

        private static long CollectStars()
        {
            var result = 0L;

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Let the Force be with you")
                {
                    break;
                }

                var coordinatesIvo = GetCoordinates(inputLine);

                inputLine = Console.ReadLine();
                var coordinatesEvil = GetCoordinates(inputLine);

                DestroyStars(coordinatesEvil);

                result += CountStars(coordinatesIvo);
            }

            return result;

        }

        private static long CountStars(int[] coordinatesIvo)
        {
            var row = coordinatesIvo[0];
            var col = coordinatesIvo[1];

            var result = 0L;
            var colLenght = matrix.GetLength(1);

            while (row >= 0 && col < colLenght)
            {
                if (IsInsideMatrix(row, col))
                {
                    result += matrix[row, col];
                }
               
                row--;
                col++;
            }

            return result;
        }

        private static bool IsInsideMatrix(int row, int col)
        {
            var rowIsInside = row >= 0 && row < matrix.GetLength(0);
            var colIsInside = col >= 0 && col < matrix.GetLength(1);

            return rowIsInside && colIsInside;
        }

        private static void DestroyStars(int[] coordinatesEvil)
        {
            var row = coordinatesEvil[0];
            var col = coordinatesEvil[1];

            while (row >= 0 && col >= 0)
            {
                if (IsInsideMatrix(row, col))
                {
                    matrix[row, col] = 0;
                }

                row--;
                col--;
            }
        }

        private static int[] GetCoordinates(string input)
        {
            return input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        private static void FillMatrix()
        {
            var cntr = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cntr;
                    cntr++;
                }
            }
        }

        private static void CreateMatrix()
        {
            var input = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            var rows = input[0];
            var cols = input[1];

            matrix = new int[rows, cols];
        }
    }
}
