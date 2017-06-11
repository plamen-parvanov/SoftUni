using System;


namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = 0;
            int f = 0;

            for (int i = 0; i < n / 2 + 4; i++)
            {
                char leftStars = '*';
                int c = 1;
                int d = n - 1 - 2 * i;
                int e = 1;
                char bla = '.';
                char special = '.';
               
                if (i == 0)
                {
                    leftStars = '@';
                    c = 0;
                    d = n - 2;
                    special = '@';
                }
            
                if (i < 2)
                {
                    b = 0;
                }

                if (n == 8 && i == n / 2 + 3)
                {
                    c = 0;
                }

                if (i > n / 2 + 1)
                {
                    bla = '*';
                }

                string leftDots = new string(bla, b);
                b++;

                string middleStars = new string('*', c);

                if (d < 0 )
                {
                    d = 0;
                }

                if (i < 2|| i >= n / 2)
                {
                    e = 0;
                }

                if (i < 3)
                {
                    f = 0;
                }
                else if (i > n / 2)
                {
                    f -= 2;
                    bla = '*';
                }

                if (f < 0)
                {
                    f = 0;
                }
                
                if (i == 1 || i > n / 2 + 1)
                {
                    special = '*';
                }
                
                string spaces = new string(' ', d);

                string rightStars = new string('*', e);
                
                string rightDots = new string(bla, f);

                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{5}{4}{3}{2}{1}{0}", leftStars, leftDots, 
                    middleStars, spaces, rightStars, rightDots, special);

                f++;
              
            }
        }
    }
}
