using System;


namespace Problem_03___Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //first row
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
            //top
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', n - 2 - 2 * i),
                    new string('.', 2 * i), new string('.', n - 2));
            }

            // bottom
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', 1 + 2 * i),
                    new string('.', n - 3 - 2 * i), new string('.', n - 2));
            }
            //last row
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
        }
    }
}
