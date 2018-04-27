using System;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i = 2 * i + 1)
            {
                Console.WriteLine(i);

            }
        }
    }
}
