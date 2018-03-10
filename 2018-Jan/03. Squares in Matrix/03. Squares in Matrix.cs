namespace _03.Squares_in_Matrix
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static char[,] matrix;
        public static void Main()
        {
            CreateMatrix();

            InitializeMatrix();

            var result = CountSquaresOfEqualChars();

            Console.WriteLine(result);
        }

        private static void CreateMatrix()
        {
            var size = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = size[0];
            var cols = size[1];

            matrix = new char[rows, cols];
        }

        private static void InitializeMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }
        }

        private static int CountSquaresOfEqualChars()
        {
            var cntr = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (FoundEqualSquare(row, col))
                    {
                        cntr++;
                    }
                }
            }

            return cntr;
        }

        private static bool FoundEqualSquare(int row, int col)
        {
            var first = matrix[row, col];
            var second = matrix[row, col + 1];
            var third = matrix[row + 1, col];
            var forth = matrix[row + 1, col + 1];

            if (first == second && first == third && first == forth)
            {
                return true;
            }

            return false;
        }
    }
}
