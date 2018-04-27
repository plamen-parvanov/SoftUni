namespace _01.Dangerous_Floor
{
    using System;
    using System.Linq;

    public class Problem01
    {
        private static char[,] chessBoard;
        public static void Main()
        {
            InitializeChessBoard();

            MakeMoves();
        }

        private static void MakeMoves()
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }

                if (ThereIsNoSuchPiece(inputLine))
                {
                    Console.WriteLine("There is no such a piece!");
                }
                else if (InvalidMove(inputLine))
                {
                    Console.WriteLine("Invalid move!");
                }
                else if (MoveGoOutOfBoard(inputLine))
                {
                    Console.WriteLine("Move go out of board!");
                }
                else
                {
                    MakeMove(inputLine);
                }

            }
        }

        private static void MakeMove(string inputLine)
        {
            var piece = inputLine[0];
            var x0 = inputLine[1] - '0';
            var y0 = inputLine[2] - '0';
            var x1 = inputLine[4] - '0';
            var y1 = inputLine[5] - '0';

            chessBoard[x0, y0] = 'x';
            chessBoard[x1, y1] = piece;
        }

        private static bool MoveGoOutOfBoard(string inputLine)
        {
            var x1 = inputLine[4] - '0';
            var y1 = inputLine[5] - '0';

            if (x1 >= 0 && x1 < 8 && y1 >= 0 && y1 < 8)
            {
                return false;
            }

            return true;
        }

        private static bool InvalidMove(string inputLine)
        {
            var piece = inputLine[0];
            var x0 = inputLine[1] - '0';
            var y0 = inputLine[2] - '0';
            var x1 = inputLine[4] - '0';
            var y1 = inputLine[5] - '0';

            switch (piece)
            {
                case 'K':
                    if (CheckIsKingMoveValid(x0, y0, x1, y1))
                    {
                        return false;
                    }

                    return true;                    

                case 'R':
                    if (CheckIsRookMoveValid(x0, y0, x1, y1))
                    {
                        return false;
                    }

                    return true;

                case 'B':
                    if (CheckIsBishopMoveValid(x0, y0, x1, y1))
                    {
                        return false;
                    }

                    return true;

                case 'Q':
                    if (CheckIsQueenMoveValid(x0, y0, x1, y1))
                    {
                        return false;
                    }

                    return true;

                default:
                    if (CheckIsPawnMoveValid(x0, y0, x1, y1))
                    {
                        return false;
                    }

                    return true;
            }
        }

        private static bool CheckIsPawnMoveValid(int x0, int y0, int x1, int y1)
        {
            if (y1 == y0 && x0 - 1 == x1)
            {
                return true;
            }

            return false;
        }

        private static bool CheckIsQueenMoveValid(int x0, int y0, int x1, int y1)
        {
            if (CheckIsRookMoveValid(x0, y0, x1, y1) || CheckIsBishopMoveValid(x0, y0, x1, y1))
            {
                return true;
            }

            return false;
        }

        private static bool CheckIsBishopMoveValid(int x0, int y0, int x1, int y1)
        {
            if (x0 - x1 == y0 - y1 || y1 - y0 == x0 - x1)
            {
                return true;
            }

            return false;
        }

        private static bool CheckIsRookMoveValid(int x0, int y0, int x1, int y1)
        {
            if (x1 == x0 && (y1 > y0 || y1 < y0))
            {
                return true;
            }
            else if (y1 == y0 && (x1 < x0 || x1 > x0))
            {
                return true;
            }

            return false;
        }

        private static bool CheckIsKingMoveValid(int x0, int y0, int x1, int y1)
        {          
            if ((x1 != x0  || y1 != y0) && (x1 >= x0 - 1 && x1 <= x0 + 1 && y1 >= y0 - 1 && y1 <= y0 + 1 ))
            {
                return true;
            }

            return false;
        }

        private static bool ThereIsNoSuchPiece(string inputLine)
        {
            var piece = inputLine[0];
            var x0 = inputLine[1] - '0';
            var y0 = inputLine[2] - '0';

            if (chessBoard[x0, y0] != piece)
            {
                return true;
            }

            return false;
        }

        private static void InitializeChessBoard()
        {
            chessBoard = new char[8, 8];

            for (int row = 0; row < 8; row++)
            {
                var inputLine = Console.ReadLine()
                    .Where(c => c != ',')
                    .ToArray();

                for (int col = 0; col < 8; col++)
                {
                    chessBoard[row, col] = inputLine[col];
                }
            }
        }
    }
}
