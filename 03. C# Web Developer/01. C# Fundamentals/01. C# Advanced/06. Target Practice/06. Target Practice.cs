namespace _06.Target_Practice
{
    using System;
    using System.Linq;

    public class Problem06
    {
        private static char[,] matrix;
        public static void Main()
        {
            CreateMatrix();

            InitializeMatrix();

            ShotAtMatrix();

            DropDownSymbols();

            PritnResult();

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
            var snake = Console.ReadLine();
            var lastRow = matrix.GetLength(0) - 1;
            var lastCol = matrix.GetLength(1) - 1;
            var cntr = 0;

            for (int row = lastRow; row >= 0; row--)
            {
                if (row % 2 == lastRow % 2)
                {
                    for (int col = lastCol; col >= 0; col--)
                    {
                        matrix[row, col] = snake[cntr % snake.Length];
                        cntr++;
                    }
                }
                else
                {
                    for (int col = 0; col <= lastCol; col++)
                    {
                        matrix[row, col] = snake[cntr % snake.Length];
                        cntr++;
                    }
                }


            }
        }

        private static void ShotAtMatrix()
        {
            var shotInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (IsInBlastRadius(row, col, shotInfo))
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }
        }

        private static bool IsInBlastRadius(int row, int col, int[] shotInfo)
        {
            var shotRow = shotInfo[0];
            var shotCol = shotInfo[1];
            var shotRadius = shotInfo[2];

            var temp = Math.Pow(row - shotRow, 2) + Math.Pow(col - shotCol, 2);

            if (temp <= Math.Pow(shotRadius, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void DropDownSymbols()
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var lastRow = matrix.GetLength(0) - 1;
                for (int row = lastRow; row >= 0; row--)
                {
                    if (matrix[row, col] == ' ')
                    {
                        ColomnDropDown(row, col);
                        break;
                    }
                }
            }
        }

        private static void ColomnDropDown(int row, int col)
        {
            var last = matrix.GetLength(0);
            var arr = new char[last];
            for (int i = 0; i < last; i++)
            {
                arr[i] = matrix[i, col];
                matrix[i, col] = ' ';
            }

            arr = arr.Where(x => x != ' ').ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                matrix[last - 1 - i, col] = arr[arr.Length - 1 - i];
            }
        }

        private static void PritnResult()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

    }
}
