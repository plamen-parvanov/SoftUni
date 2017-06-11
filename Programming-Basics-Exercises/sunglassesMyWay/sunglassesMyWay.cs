using System;


namespace sunglassesMyWay
{
    class sunglassesMyWay
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // first row
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            for (int i = 0; i < n - 2; i++)
            {
                var spaces = ' ';
               

                //middle rows
                Console.Write("*");
                Console.Write( new string ('/', n *2 - 2));
                Console.Write("*");
                if (i == (n - 1) / 2 - 1)
                {
                    spaces = '/';
                }

                Console.Write( new string(spaces, n));

                Console.Write("*");
                Console.Write(new string('/', n *2 -2));
                Console.WriteLine("*");
                
                spaces = ' ';   

            }
            //last row
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
