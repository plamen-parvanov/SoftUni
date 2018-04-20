namespace _07.Lego_Blocks
{
    using System;
    using System.Linq;

    public class Problem07
    {
        private static int[][] firstJagged;
        private static int[][] secondJagged;
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());

            firstJagged = InitializeJaggedArray(rows);

            secondJagged = InitializeJaggedArray(rows);

            if (FirstAndSecondFits())
            {
                 var matrix = MakeBlock();

                PrintBlock(matrix);
            }
            else
            {
                var numberOfCells = CountCellsInBothArrays();

                Console.WriteLine($"The total number of cells is: {numberOfCells}");
            }
        }

        private static int[][] InitializeJaggedArray(int rows)
        {
           
            var jagged = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jagged[i] = inputLine;
            }

            return jagged;
        }

        private static bool FirstAndSecondFits()
        {
            var length = firstJagged[0].Length + secondJagged[0].Length;
             
            for (int row = 1; row < firstJagged.Length; row++)
            {
                if (length != firstJagged[row].Length + secondJagged[row].Length)
                {
                    return false;
                }
            }

            return true;
        }

        private static int[,] MakeBlock()
        {
            var rows = firstJagged.GetLength(0);
            var cols = firstJagged[0].Length + secondJagged[0].Length;

            var matrix = new int[rows,cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < firstJagged[row].Length; col++)
                {
                    matrix[row, col] = firstJagged[row][col];
                }

                for (int col = 0; col < secondJagged[row].Length; col++)
                {
                    var currCol = matrix.GetLength(1) - 1 - col;
                    matrix[row, currCol] = secondJagged[row][col];
                }
            }

            return matrix;
        }

        private static void PrintBlock(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("[");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine($"{matrix[row, col]}]");
                        break;
                    }

                    Console.Write($"{matrix[row, col]}, ");
                }
            }
        }

        private static int CountCellsInBothArrays()
        {
            var sum = 0;
            var rows = firstJagged.Length;

            for (int row = 0; row < rows; row++)
            {
                sum += firstJagged[row].Length;
                sum += secondJagged[row].Length;
            }

            return sum;
        }
    }
}
