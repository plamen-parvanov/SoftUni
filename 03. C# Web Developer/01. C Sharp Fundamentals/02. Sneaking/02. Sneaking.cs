namespace _02.Sneaking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static char[][] jagged;
        private static int samRow;
        private static int samCol;
        private static int nikoladzeRow;
        private static int nikoladzeCol;
        static void Main(string[] args)
        {

            InitializeJaggedArray();

            MakeMoves();

            PrintResult();
        }

        private static void PrintResult()
        {
            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void MakeMoves()
        {
            var allMoves = new Queue<char>(Console.ReadLine().ToCharArray());

            while (true)
            {
                MoveEnemies();

                GetSamPosition();

                if (EnemySeesSam())
                {
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    jagged[samRow][samCol] = 'X';
                    break;
                }

                SamMoves(allMoves.Dequeue());

                if (samRow == nikoladzeRow)
                {
                    Console.WriteLine("Nikoladze killed!");
                    jagged[nikoladzeRow][nikoladzeCol] = 'X';
                    break;
                }
            }
        }

        private static void InitializeJaggedArray()
        {
            jagged = new char[int.Parse(Console.ReadLine())][];

            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = Console.ReadLine().ToCharArray();

                SearchForNikoladze(row);
            }
        }

        private static void SearchForNikoladze(int row)
        {
            if (jagged[row].Contains('N'))
            {
                nikoladzeRow = row;
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    if (jagged[row][col] == 'N')
                    {
                        nikoladzeCol = col;
                        return;
                    }
                }
            }
        }

        private static void SamMoves(char direction)
        {
            switch (direction)
            {
                case 'U':
                    jagged[samRow][samCol] = '.';
                    jagged[samRow - 1][samCol] = 'S';
                    samRow--;
                    break;
                case 'D':
                    jagged[samRow][samCol] = '.';
                    jagged[samRow + 1][samCol] = 'S';
                    samRow++;
                    break;
                case 'L':
                    jagged[samRow][samCol] = '.';
                    jagged[samRow][samCol - 1] = 'S';
                    samCol--;
                    break;
                case 'R':
                    jagged[samRow][samCol] = '.';
                    jagged[samRow][samCol + 1] = 'S';
                    samCol++;
                    break;
            }
        }

        private static void GetSamPosition()
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                if (!jagged[row].Contains('S'))
                {
                    continue;
                }

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    if (jagged[row][col] == 'S')
                    {
                        samRow = row;
                        samCol = col;
                        return;
                    }
                }
            }
        }

        private static bool EnemySeesSam()
        {
            var leftSide = string.Join("", jagged[samRow]).Substring(0, samCol);
            var rightSide = string.Join("", jagged[samRow]).Substring(samCol + 1);

            if (rightSide.Contains('d') || leftSide.Contains('b'))
            {
                return true;
            }

            return false;
        }

        private static void MoveEnemies()
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                var currArr = jagged[row];

                if (currArr.Contains('d'))
                {
                    MoveLeft(currArr);
                }
                else if (jagged[row].Contains('b'))
                {
                    MoveRight(currArr);
                }
            }
        }

        private static void MoveRight(char[] arr)
        {
            var lastEll = arr.Length - 1;

            if (arr[lastEll] == 'b')
            {
                arr[lastEll] = 'd';
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 'b')
                    {
                        arr[i] = '.';
                        arr[i + 1] = 'b';
                        break;
                    }
                }
            }
        }

        private static void MoveLeft(char[] arr)
        {
            if (arr[0] == 'd')
            {
                arr[0] = 'b';
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 'd')
                    {
                        arr[i - 1] = 'd';
                        arr[i] = '.';
                        break;
                    }
                }
            }
        }
    }
}