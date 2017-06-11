using System;


namespace Nums1To20
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var n = decimal.Parse(Console.ReadLine());



            for (int row = 1; row <= (n - 2); row++)
            {
                Console.Write("*");

                for (int col = 1; col <= n - 2; col++)

                {
                    Console.Write(" ");
                }

            }

             
        }
    }
}
