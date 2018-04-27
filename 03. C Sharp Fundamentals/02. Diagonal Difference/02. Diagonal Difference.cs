namespace _02.Diagonal_Difference
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = InitializeMatrixWith(size);

            var diffBetweenDiagonals = CalculateDiagonalDiff(matrix);

            Console.WriteLine(diffBetweenDiagonals);
        }

        private static int[,] InitializeMatrixWith(int size)
        {
            var matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currLine = Console.ReadLine()
                                      .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currLine[col];
                }
            }

            return matrix;
        }

        private static int CalculateDiagonalDiff(int[,] matrix)
        {
            var primaryDiagonal = SumPrimaryDiagonal(matrix);

            var secondaryDiagonal = SumSeconadaryDiagonal(matrix);

            return Math.Abs(primaryDiagonal - secondaryDiagonal);
        }

        private static int SumPrimaryDiagonal(int[,] matrix)
        {
            var sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
            }

            return sum;
        }

        private static int SumSeconadaryDiagonal(int[,] matrix)
        {
            var sum = 0;

            for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0); row++, col--)
            {
                sum += matrix[row, col];
            }

            return sum;
        }
    }
}
