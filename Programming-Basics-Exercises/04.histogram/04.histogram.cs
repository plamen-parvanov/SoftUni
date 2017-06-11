using System;


namespace _04.histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0d;
            var p2 = 0d;
            var p3 = 0d;
            var p4 = 0d;
            var p5 = 0d;
            for ( int i=0 ; i < n ; i++ )
            {
                var number = int.Parse(Console.ReadLine());
                
                    
                if ( number >= 800 )
                {
                    p5 = p5 + 1d;
                }

                else if ( number >= 600 )
                {
                    p4 = p4 + 1d;
                }

                else if ( number >= 400 )
                {
                    p3 = p3 + 1d;
                }

                else if ( number >= 200 )
                {
                    p2 = p2 + 1d;
                }

                else
                {
                    p1 = p1 + 1d;
                }
            }
            Console.WriteLine("{0:P2}", p1 / n);
            Console.WriteLine("{0:P2}", p2 / n);
            Console.WriteLine("{0:P2}", p3 / n);
            Console.WriteLine("{0:F2}%", p4 * 100d / n);
            Console.WriteLine("{0:F2}%", p5 * 100d / n);



        }
    }
}
