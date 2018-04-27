namespace _04.Pascal_Triangle
{
    using System;

    public class Problem04
    {
        private static long[][] jagged;
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            jagged = new long[rows][];

            InitializeJagged();

            PrintJagged();
        }

        private static void InitializeJagged()
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new long[row + 1];
                jagged[row][0] = 1;
                jagged[row][row] = 1;

                for (int col = 1; col < row; col++)
                {
                    jagged[row][col] = jagged[row - 1][col - 1] + jagged[row - 1][col];
                }
            }
        }

        private static void PrintJagged()
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
