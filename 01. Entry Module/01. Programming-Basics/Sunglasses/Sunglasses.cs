using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var slash = '/';
                var spaces = ' ';

                if (i == 0 || i == n - 1)
                {
                    slash = '*';
                }

                if (i == (n + 1) / 2 - 1)
                {
                    spaces = '|';
                }
               
                Console.WriteLine("*" + new string (slash , n * 2 - 2) +"*" +new string(spaces, n) 
                    + "*" + new string(slash, n * 2 - 2) + "*");
                
            }
        }
    }
}
