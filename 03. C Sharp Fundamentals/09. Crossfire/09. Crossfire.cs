namespace _09.Crossfire
{
    using System;
    using System.Linq;

    public class Problem09
    {
        private static int[][] jagged;
        public static void Main()
        {
            Initializeagged();

            DestroyCells();
        }

        private static void Initializeagged()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = inputLine[0];
            var cols = inputLine[1];

            jagged = new int[rows][];
            var cntr = 0;

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new int[cols];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = ++cntr;
                }
            }
        }

        private static void DestroyCells()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Nuke it from orbit")
                {
                    break;
                }

                DestroyFrom(inputLine);
            }
        }

        private static void DestroyFrom(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var row = arr[0];
            var col = arr[1];
            var radius = arr[2];

            CLearCellsInCol(row, col, radius);

            ClearCellsInRow(row, col, radius);

        }

        private static void ClearCellsInRow(int row, int col, int radius)
        {
            var length = 2 * radius;
            for (int i = 0; i < length; i++)
            {
                var currCol = col - radius + i;
                if (currCol >= 0 && currCol < jagged.GetLength(1))
                {
                    jagged[row][currCol] = 0;
                }
            }

            jagged[row] = jagged[row].Where(x => x > 0).ToArray();
        }

        private static void CLearCellsInCol(int row, int col, int radius)
        {
            var length = 2 * radius + 1;
            for (int i = 0; i < length; i++)
            {
                var currRow = row - radius + i;
                if (currRow >= 0 && currRow < jagged.GetLength(0))
                {
                    jagged[currRow][col] = 0;
                }
               
            }
        }
    }
}
