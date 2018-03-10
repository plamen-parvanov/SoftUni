namespace _04.Maximal_Sum
{
    using System;
    using System.Linq;

    public class Problem04
    {
        public static int[,] matrix;
        public static int[] startIndex = new int[2];
        public static void Main()
        {
            CreateMatrix();

            InitializeMatrix();

            Console.WriteLine($"Sum = {GetSquareMaxSum()}");

            PrintMaxSquare();
        }

        private static void CreateMatrix()
        {
            var size = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            var rows = size[0];
            var cols = size[1];
            matrix = new int[rows, cols];
        }

        private static void InitializeMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }
        }

        private static int GetSquareMaxSum()
        {
            var maxSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var sum = CalculateSquareSum(row, col);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startIndex = new int[] { row, col };
                    }
                }
            }

            return maxSum;
        }

        private static int CalculateSquareSum(int row, int col)
        {
            var first = matrix[row, col];
            var second = matrix[row, col + 1];
            var third = matrix[row, col + 2];
            var forth = matrix[row + 1, col];
            var fifth = matrix[row + 1, col + 1];
            var sixth = matrix[row + 1, col + 2];
            var seventh = matrix[row + 2, col];
            var eighth = matrix[row + 2, col + 1];
            var nineth = matrix[row + 2, col + 2];

            return first + second + third + forth + fifth + sixth + seventh + eighth + nineth;
        }

        private static void PrintMaxSquare()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[startIndex[0] + i, startIndex[1] + j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
