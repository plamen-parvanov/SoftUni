using System;


namespace _09.Multiplication_Table
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                int sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
