using System;


namespace xMassTree
{
    class xMassTree
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                Console.Write( new string (' ', n - i));
               
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
