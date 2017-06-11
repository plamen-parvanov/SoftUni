using System;


namespace _10.Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n + 1 + n % 2; i++)
            {
                if (i ==  (n + 1 + n % 2) / 2 )
                {
                    Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
                }
                else
                {
                    char special = ' ';
                    if (i == 0 || i == n + n % 2)
                    {
                        special = '%';
                    }

                    Console.WriteLine("%{0}%", new string(special, 2 * n - 2));
                }   
            }
        }
    }
}
