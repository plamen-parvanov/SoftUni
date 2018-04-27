namespace _02.Monopoly
{
    using System;
    using System.Linq;

    public class Problem02
    {
        private static int[,] board;
        private static int turns;
        private static int money;
        private static int hotels;

        public static void Main()
        {
            CreateBoard();

            FillTheBoard();

            StartPlaying();

            PrintFinal();
        }

        private static void PrintFinal()
        {
            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }

        private static void StartPlaying()
        {
            turns = 0;
            money = 50;
            hotels = 0;
            var rows = board.GetLength(0);

            for (int row = 0; row < rows; row++)
            {

                // ili  int index = row % 2 == 0 ? col : currentRow.Length - col - 1;
                //bez left i right a samo s edin cikul board[row, index]

                if (row % 2 == 0)
                {
                    MoveRight(row);

                    continue;
                }

                MoveLeft(row);
            }
        }

        private static void MoveLeft(int row)
        {
            var cols = board.GetLength(1);

            for (int col = cols - 1; col >= 0; col--)
            {
                var @object = board[row, col];

                Execute(@object, row, col);

                money += hotels * 10;
                turns++;
            }
        }

        private static void MoveRight(int row)
        {
            var cols = board.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                var @object = board[row, col];

                Execute(@object, row, col);

                money += hotels * 10;
                turns++;
            }
        }

        private static void Execute(int @object, int row, int col)
        {
            switch (@object)
            {
                case 'H':
                    hotels++;
                    Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                    money = 0;
                    break;

                case 'J':
                    Console.WriteLine($"Gone to jail at turn {turns}.");
                    turns += 2;
                    money += hotels * 20;
                    break;

                case 'S':
                    var spent = (row + 1) * (col + 1);
                    // ako e edin cikul   int columnIndex = row % 2 == 0 ? col : index;
                    //int spent = Math.Min((columnIndex + 1) * (row + 1), money);

                    if (spent > money)
                    {
                        spent = money;
                    }
                    money -= spent;
                    Console.WriteLine($"Spent {spent} money at the shop.");
                    break;

                default:
                    break;
            }
        }

        private static void FillTheBoard()
        {
            var rows = board.GetLength(0);
            var cols = board.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = input[col];
                }
            }
        }

        private static void CreateBoard()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var cols = input[1];

            board = new int[rows, cols];
        }
    }
}
