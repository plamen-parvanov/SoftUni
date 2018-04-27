namespace _2.Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    public class Problem02
    {
        public static int indexRow;
        public static int indexCol;
        public static void Main()
        {
            var matrix = InitializeMatrix();

            var maxSum = GetMaxSquareSum(matrix);

            PrintBiggestSquare(matrix);

            Console.WriteLine(maxSum);
        }

        private static int[,] InitializeMatrix()
        {
            var input = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var cols = input[1];
            var matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = inputLine[j];
                }
            }

            return matrix;
        }

        private static int CalculateSquare(int[,] matrix, int i, int j)
        {
            return matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
        }

        private static int GetMaxSquareSum(int[,] matrix)
        {
            var maxSum = int.MinValue;
         
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {

                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    var currSum = CalculateSquare(matrix, i, j);
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        indexRow = i;
                        indexCol = j;
                    }
                }
            }

            return maxSum;
        }

        private static void PrintBiggestSquare(int[,] matrix)
        {
            Console.WriteLine("{0} {1}",
                matrix[indexRow, indexCol], matrix[indexRow, indexCol + 1]);
            Console.WriteLine("{0} {1}",
                matrix[indexRow + 1, indexCol], matrix[indexRow + 1, indexCol + 1]);
        }
    }
}
