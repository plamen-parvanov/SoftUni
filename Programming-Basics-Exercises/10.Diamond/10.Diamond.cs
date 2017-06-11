using System;


namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < (n + 1) / 2; i++)
            //{
            //    Console.Write(new string('-', (n - 1) / 2 - i) + "*" + new string('-', (4 * i - n % 2) / 2));

            //    if (i > 0 || n % 2 == 0)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(new string('-', (n - 1) / 2 - i));
            //}

            //for (int i = 0; i < (n - 1) / 2; i++)
            //{
            //    var a = n - 4 - 2 * i;
            //    Console.Write(new string('-', i + 1));
            //    Console.Write("*");
            //    if (a < 0)
            //    {
            //        a = 0;
            //    }
            //    Console.Write(new string('-', a));
            //    if (i != n / 2 - 1)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine(new string('-', i + 1));
            //}


            var a = (n - 1) / 2;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                object special = null;
                if (n % 2 == 0 || i > 0)
                {
                    special = '*';
                }
                Console.WriteLine("{0}*{1}{2}{0}", new string('-', a - i), new string('-', (4 * i - n % 2) / 2), special);
            }

            for (int i = 1; i < a; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', i), new string('-', n - 2 - 2 * i));
            }

            if (n > 2)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', a), new string('*', 2 - n % 2));
            }
        }
    }
}
