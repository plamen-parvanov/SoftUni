namespace _08.Radioactive_Bunnies
{
    using System;
    using System.Linq;

    public class Problem08
    {
        private static char[,] matrix;
        private static int[] playerIndexes;
        private static bool win;
        public static void Main()
        {
            CreateMatrix();

            InitializeMatrix();

            ExecuteCommands();
        }

        private static void CreateMatrix()
        {
            var inputLine = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = inputLine[0];
            var cols = inputLine[1];

            matrix = new char[rows, cols];
        }

        private static void InitializeMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];

                    if (inputLine[col] == 'P')
                    {
                        playerIndexes = new int[2] { row, col };
                    }
                }
            }

        }

        private static void ExecuteCommands()
        {
            var moves = Console.ReadLine();

            for (int i = 0; i < moves.Length; i++)
            {
                win = false;

                var currMove = moves[i];

                PlayerMake(currMove);

                BunniesSpread();

                CheckForWinOrLose();
            }
        }

        private static void PlayerMake(char command)
        {
            switch (command)
            {
                case 'L':
                    MoveLeftOrRight(-1);
                    break;
                case 'R':
                    MoveLeftOrRight(1);
                    break;
                case 'U':
                    MoveUpOrDown(-1);
                    break;
                case 'D':
                    MoveUpOrDown(1);
                    break;
            }
        }

        private static void MoveLeftOrRight(int step)
        {
            var rowPlayer = playerIndexes[0];
            var colPlayer = playerIndexes[1];
            var playerNewCol = colPlayer + step;

            if (playerNewCol < matrix.GetLength(1) && playerNewCol >= 0)
            {
                if (matrix[rowPlayer, playerNewCol] != 'B')
                {
                    matrix[rowPlayer, playerNewCol] = 'P';
                }
                
                playerIndexes[1] = playerNewCol;
            }
            else
            {
                win = true;
            }
           
                matrix[rowPlayer, colPlayer] = '.';
            
        }

        private static void MoveUpOrDown(int step)
        {
            var rowPlayer = playerIndexes[0];
            var colPlayer = playerIndexes[1];
            var playerNewStep = rowPlayer + step;

            if (playerNewStep >= 0 && playerNewStep < matrix.GetLength(0))
            {
                if (matrix[playerNewStep, colPlayer] != 'B')
                {
                    matrix[playerNewStep, colPlayer] = 'P';
                }

                playerIndexes[0] = playerNewStep;
            }
            else
            {
                win = true;
            }

                matrix[rowPlayer, colPlayer] = '.';         
        }

        private static void BunniesSpread()
        {
            var tempMatrix = (char [,])matrix.Clone();

            for (int row = 0; row < tempMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < tempMatrix.GetLength(1); col++)
                {
                    var currSymbol = tempMatrix[row, col];

                    if (currSymbol == 'B')
                    {
                        SpreadCurrentBunny(row, col);
                    }
                }
            }
        }

        private static void SpreadCurrentBunny(int row, int col)
        {
            var left = col - 1;
            if (left >= 0)
            {
                matrix[row, left] = 'B';
            }

            var right = col + 1;
            if (right < matrix.GetLength(1))
            {
                matrix[row, right] = 'B';
            }

            var up = row - 1;
            if (up >= 0)
            {
                matrix[up, col] = 'B';
            }

            var down = row + 1;
            if (down < matrix.GetLength(0))
            {
                matrix[down, col] = 'B';
            }
        }

        private static void CheckForWinOrLose()
        {
            var rowPlayer = playerIndexes[0];
            var colPlayer = playerIndexes[1];
             
            if (win)
            {
                PrintMatrix();

                Console.WriteLine($"won: {rowPlayer} {colPlayer}");

                Environment.Exit(0);
            }
            else if (matrix[rowPlayer, colPlayer] == 'B')
            {
                PrintMatrix();

                Console.WriteLine($"dead: {rowPlayer} {colPlayer}");

                Environment.Exit(0);
            }
        }

        private static void PrintMatrix()
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
