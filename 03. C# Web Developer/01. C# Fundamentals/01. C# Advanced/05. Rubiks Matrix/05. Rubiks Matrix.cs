namespace _05.Rubiks_Matrix
{
    using System;
    using System.Linq;

    public class Problem05
    {
        public static int[,] matrix;
        public static void Main()
        {
            CreateMatrix();

            InitializeMatrix();

            ExecuteCommands();

            PrintCommandsToRearangeMatrix();
        }

        private static void CreateMatrix()
        {
            var size = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = size[0];
            var cols = size[1];

            matrix = new int[rows, cols];
        }

        private static void InitializeMatrix()
        {
            var cntr = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = ++cntr;
                }
            }
        }

        private static void ExecuteCommands()
        {
            var commandsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNum; i++)
            {
                var command = Console.ReadLine();

                Execute(command);
            }
        }

        private static void Execute(string input)
        {
            var arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var command = arr[1];

            switch (command)
            {
                case "left":
                    MoveNumsInRowLeft(arr);
                    break;
                case "right":
                    MoveNumsInRowRight(arr);
                    break;
                case "up":
                    MoveNumsInColUp(arr);
                    break;
                case "down":
                    MoveNumsInColDown(arr);
                    break;
            }
        }

        private static void MoveNumsInColUp(string[] arr)
        {
            var col = int.Parse(arr[0]);
            var move = int.Parse(arr[2]);
            for (int i = 0; i < move % matrix.GetLength(0); i++)
            {
                MoveNumsUpIn(col);
            }
        }

        private static void MoveNumsUpIn(int col)
        {
            var temp = matrix[0, col];

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                matrix[i, col] = matrix[i + 1, col];
            }

            matrix[matrix.GetLength(0) - 1, col] = temp;
        }

        private static void MoveNumsInColDown(string[] arr)
        {
            var col = int.Parse(arr[0]);
            var move = int.Parse(arr[2]);

            for (int i = 0; i < move % matrix.GetLength(0); i++)
            {
                MoveNumsDownIn(col);
            }
        }

        private static void MoveNumsDownIn(int col)
        {
            var lastElIndex = matrix.GetLength(0) - 1;
            var temp = matrix[lastElIndex, col];

            for (int i = 0; i < lastElIndex; i++)
            {
                matrix[lastElIndex - i, col] = matrix[lastElIndex - 1 - i, col];
            }

            matrix[0, col] = temp;
        }

        private static void MoveNumsInRowLeft(string[] arr)
        {
            var row = int.Parse(arr[0]);
            var move = int.Parse(arr[2]);

            for (int i = 0; i < move % matrix.GetLength(1); i++)
            {
                MoveNumsLeftIn(row);
            }
        }

        private static void MoveNumsLeftIn(int row)
        {
            var temp = matrix[row, 0];

            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                matrix[row, i] = matrix[row, i + 1];
            }

            matrix[row, matrix.GetLength(1) - 1] = temp;
        }

        private static void MoveNumsInRowRight(string[] arr)
        {
            var row = int.Parse(arr[0]);
            var move = int.Parse(arr[2]);

            for (int i = 0; i < move % matrix.GetLength(1); i++)
            {
                MoveNumsRightIn(row);
            }
        }

        private static void MoveNumsRightIn(int row)
        {
            var last = matrix.GetLength(1) - 1;
            var temp = matrix[row, last];

            for (int i = 0; i < last; i++)
            {
                matrix[row, last - i] = matrix[row, last - 1 - i];
            }

            matrix[row, 0] = temp;
        }

        private static void PrintCommandsToRearangeMatrix()
        {
            var cntr = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    cntr++;

                    if (cntr == matrix[row, col])
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        var swapEll = new int[2] { row, col };
                        var swapedEll = GetIndexOfSwapedEll(cntr);                     
                        Console.WriteLine("Swap ({0}) with ({1})",
                                          string.Join(", ", swapEll),
                                          string.Join(", ", swapedEll));

                        SwapEllements(swapEll, swapedEll);
                    }
                }
            }
        }

        private static int[] GetIndexOfSwapedEll(int num)
        {
            var arr = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var currNum = matrix[row, col];

                    if (currNum == num)
                    {
                        arr[0] = row;
                        arr[1] = col;                  
                        return arr;
                    }
                }
            }
            return arr;
        }

        private static void SwapEllements(int[] swap, int[] swapped)
        {
            var temp = matrix[swap[0], swap[1]];
            matrix[swap[0], swap[1]] = matrix[swapped[0], swapped[1]];
            matrix[swapped[0], swapped[1]] = temp;

        }
    }
}
