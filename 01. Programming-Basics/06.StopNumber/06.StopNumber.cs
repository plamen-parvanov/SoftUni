using System;


namespace _06.StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (; m >= n; m--)
            {
                int a = m % 2;
                int b = m % 3; 

                if (a == 0 && b == 0)
                {
                    if (m == s)
                    {
                        Console.WriteLine();
                        return;
                    }
                    Console.Write(m +" ");
                }
            }
            Console.WriteLine();
        }
    }
}
