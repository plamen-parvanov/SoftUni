using System;


namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); // da probvam da q napravq new string za speices + * 
            //top                                              // sled tova cikul za ostanalite "* " 
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string (' ', n - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //bottom

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write( new string (' ', i ));
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
