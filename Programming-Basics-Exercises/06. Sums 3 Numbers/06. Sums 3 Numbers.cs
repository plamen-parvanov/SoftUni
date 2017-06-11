using System;


namespace _06.Sums_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                if (a < b)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, b, c);
                }

                else
                {
                    Console.WriteLine("{0} + {1} = {2}", b, a, c);
                }
            }

            else if (a + c == b)
            {
                if (a < c)
                {
                    Console.WriteLine("{0} + {1} = {2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2}", c, a, b);
                }

            }

            else if (c + b == a)
            {
                if (c < b)
                {
                    Console.WriteLine("{0} + {1} = {2}", c, b, a);
                }

                else
                {
                    Console.WriteLine("{0} + {1} = {2}", b, c, a);
                }
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
