using System;


namespace _07.Divisible_by_3
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
