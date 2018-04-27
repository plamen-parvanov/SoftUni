using System;


namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int thirdN = n % 10;
            int secondN = (n / 10) % 10;
            int firstN = (n / 100) % 10;

            for (int i = 0; i < firstN + secondN; i++)
            {
                for (int j = 0; j < firstN + thirdN; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstN;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondN;
                    }
                    else
                    {
                        n += thirdN;
                    }
                    Console.Write(n +" ");
                }
                Console.WriteLine();
            }  
        }
    }
}
