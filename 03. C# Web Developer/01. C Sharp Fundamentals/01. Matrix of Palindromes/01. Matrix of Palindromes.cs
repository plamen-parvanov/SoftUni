namespace _01.Matrix_of_Palindromes
{
    using System;
    using System.Linq;

    public class Problem01
    {
        public static string[,] matrix;
        public static void Main()
        {
            InitializeMatrix();

            PrintMatrix();
        }

        private static void InitializeMatrix()
        {
            var input = Console.ReadLine()
                                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            var rows = input[0];
            var cols = input[1];
            matrix = new string[rows, cols];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = "" + alphabet[row] + alphabet[col + row] + alphabet[row];

                    //matrix[row, col] = string.Format("{0}{1}{0}", (char)('a' + row), (char)('a' + row + col)); 

                }
            }
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
