using System;


namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            DrawFilledSquare(n);
        }
        static void DrawFilledSquare(int n)
        {
            DrawFirstOrLastRow(n);
            DrawMiddleRows(n);
            DrawFirstOrLastRow(n);
        }

        static void DrawFirstOrLastRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

            static void DrawMiddleRows(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                DrawLine(n);
            }
        }
        static void DrawLine(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine("-");
        }
    }
}
