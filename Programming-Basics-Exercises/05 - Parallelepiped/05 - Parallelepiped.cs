using System;


namespace _05___Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftDots = 0;
            int i = 0;
            var rightDots = new string('.', 2 * n + 1);
            var tilda = new string('~', n - 2);
            Console.WriteLine("+{0}+{1}",tilda, rightDots);

            for ( i = 0; i <= 2 * n; i++)
            {
                rightDots = new string('.', 2 * n - i);
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', leftDots + i), tilda, rightDots);
               
            }

            for (i = 0; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', i), new string('.', 2 * n - i), tilda);
            }

            Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1), tilda);
        }
        
    }
}
