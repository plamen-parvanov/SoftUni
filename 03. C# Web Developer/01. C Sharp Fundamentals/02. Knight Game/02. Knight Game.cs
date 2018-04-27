namespace _02.Knight_Game
{
    using System;

    public class Problem02
    {
        private static char[,] chessBoard;
        public static void Main()
        {
            CreateChessBoard();

            FillTheChessBoard();

            var result = CalculateMinKnightsToRemove();

            Console.WriteLine(result);
        }

        private static int CalculateMinKnightsToRemove()
        {
            var rows = chessBoard.GetLength(0);
            var cols = chessBoard.GetLength(1);

            var maxAttacks = 0;
            var maxAttRow = 0;
            var maxAttCol = 0;
            var removed = 0;
            var needToRemove = true;

            while (true)
            {
                needToRemove = false;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (chessBoard[row, col] == 'K')
                        {
                            var currAttacks = CalculateCountOfAttacks(row, col);

                            if (currAttacks > maxAttacks)
                            {
                                maxAttRow = row;
                                maxAttCol = col;
                                maxAttacks = currAttacks;
                                needToRemove = true;
                            }
                        }
                    }
                }

                if (needToRemove)
                {
                    RemoveMostAttackedKnight(maxAttRow, maxAttCol);
                    maxAttacks = 0;
                    removed++;
                }
                else
                {
                    break;
                }
            }

            return removed;
        }

        private static int CalculateCountOfAttacks(int row, int col)
        {
            var rows = chessBoard.GetLength(0);
            var cols = chessBoard.GetLength(1);
            var attacks = 0;
            Func<int,int, bool> isThereKnight = (x, y) => chessBoard[row + x, col + y] == 'K';
            Func<int, int, bool> isInsideTheBoard = (x, y) => row + x >= 0 && row + x < rows && col + y >= 0 && col + y < cols;

            if (isInsideTheBoard(-2, -1) && isThereKnight(-2, -1))
            {
                attacks++;
            }

            if (isInsideTheBoard(-2, 1) && isThereKnight(-2, 1))
            {
                attacks++;
            }

            if (isInsideTheBoard(-1, -2) && isThereKnight(-1, -2))
            {
                attacks++;
            }

            if (isInsideTheBoard(-1, 2) && isThereKnight(-1, 2))
            {
                attacks++;
            }

            if (isInsideTheBoard(1, -2) && isThereKnight(1, -2))
            {
                attacks++;
            }

            if (isInsideTheBoard(1, 2) && isThereKnight(1, 2))
            {
                attacks++;
            }

            if (isInsideTheBoard(2, -1) && isThereKnight(2, -1))
            {
                attacks++;
            }

            if (isInsideTheBoard(2, 1) && isThereKnight(2, 1))
            {
                attacks++;
            }

            return attacks;
        }

        private static void RemoveMostAttackedKnight(int row, int col)
        {
            chessBoard[row, col] = 'O';
        }

        private static void FillTheChessBoard()
        {
            var rows = chessBoard.GetLength(0);
            var cols = chessBoard.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                var inputLine = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    chessBoard[row, col] = inputLine[col];
                }
            }
        }

        private static void CreateChessBoard()
        {
            var n = int.Parse(Console.ReadLine());

            chessBoard = new char[n, n];
        }
    }
}
