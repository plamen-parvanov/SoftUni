using System;


namespace Rectangle_of_10_x_10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine( new string ('*', n));
            }
        }
    }
}
