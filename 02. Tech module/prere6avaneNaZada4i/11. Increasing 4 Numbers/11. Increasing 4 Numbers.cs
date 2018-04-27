using System;


namespace _11.Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
         
            for (int i = a; i <= b - 3; i++)
            {
                for (int j = i + 1; j <= b - 2; j++)
                {
                    for (int k = j + 1; k <= b - 1; k++)
                    {
                        for (int l = k +1; l <= b; l++)
                        {
                                Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);                       
                        }
                    }
                }
            }
            if (a - b < 4)
            {
                Console.WriteLine("No");
            }
        }
    }
}
