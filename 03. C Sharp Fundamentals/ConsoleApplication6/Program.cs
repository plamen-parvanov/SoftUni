namespace ConsoleApplication6
{
    using System;
    using System.Collections.Generic;

    public class Problem02
    {
        private static char[,] matrix;
        private static int samRow;
        private static int samCol;
        private static int NikoladzeRow;
        public static int NIkoladzeCol;
        public static void Main()
        {
            CreateMatrix();

            FillInMatrix();

            MakingMoves();

            PrintResult();
        }

        private static void CreateMatrix()
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = rows * 2 + 1;

            matrix = new char[rows, cols];
        }

        private static void FillInMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currLine = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currLine[col];
                }
            }
        }

        private static void MakingMoves()
        {
            var samAllMoves = new Queue<char>(Console.ReadLine().ToCharArray());

            while (true)
            {
                MoveAllEnemies();

                if (EnemySeesSam())
                {
                    matrix[samRow, samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    return;
                }

                SamMakesMove(samAllMoves.Dequeue());

                if (samRow == NikoladzeRow)
                {
                    matrix[NikoladzeRow, NIkoladzeCol] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    return;
                }
            }

        }

        private static void MoveAllEnemies()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                MoveEnemy(row);
            }
        }

        private static void MoveEnemy(int row)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var currEll = matrix[row, col];

                switch (currEll)
                {
                    case '.':
                        break;
                    case 'b':
                        MovesRight(row, col);
                        return;
                    case 'd':
                        MovesLeft(row, col);
                        return;
                    case 'N':
                        NikoladzeRow = row;
                        NIkoladzeCol = col;
                        return;
                }
            }
        }

        private static void MovesRight(int row, int col)
        {
            if (col + 1 > matrix.GetLength(1) - 1)
            {
                matrix[row, col] = 'd';
            }
            else
            {
                matrix[row, col] = '.';
                matrix[row, col + 1] = 'b';
            }
        }

        private static void MovesLeft(int row, int col)
        {
            if (col - 1 < 0)
            {
                matrix[row, col] = 'b';
            }
            else
            {
                matrix[row, col] = '.';
                matrix[row, col - 1] = 'd';
            }
        }

        private static bool EnemySeesSam()
        {
            GetSamPosition();

            for (int col = 0; col < samCol; col++)
            {
                var currSymbol = matrix[samRow, col];
                if (currSymbol == 'b')
                {
                    return true;
                }
            }

            for (int col = samCol + 1; col < matrix.GetLength(1); col++)
            {
                var currSymbol = matrix[samRow, col];
                if (currSymbol == 'd')
                {
                    return true;
                }
            }

            return false;
        }

        private static void GetSamPosition()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var currSymbol = matrix[row, col];

                    if (currSymbol == 'S')
                    {
                        samRow = row;
                        samCol = col;
                        return;
                    }
                }
            }
        }

        private static void SamMakesMove(char move)
        {
            switch (move)
            {
                case 'U':
                    matrix[samRow, samCol] = '.';
                    matrix[samRow - 1, samCol] = 'S';
                    samRow--;

                    break;
                case 'D':
                    matrix[samRow, samCol] = '.';
                    matrix[samRow + 1, samCol] = 'S';
                    samRow++;
                    break;
                case 'L':
                    matrix[samRow, samCol] = '.';
                    matrix[samRow, samCol - 1] = 'S';
                    samCol--;
                    break;
                case 'R':
                    matrix[samRow, samCol] = '.';
                    matrix[samRow, samCol + 1] = 'S';
                    samCol++;
                    break;
            }
        }

        private static void PrintResult()
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

