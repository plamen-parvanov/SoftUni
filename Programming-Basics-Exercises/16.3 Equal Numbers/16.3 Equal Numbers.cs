using System;

namespace _16._3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            if (a == b)
            
                if (a == c)
                    Console.WriteLine("yes");

                else
                    Console.WriteLine("no");
           

            else
                Console.WriteLine("no");
        }
    }
}
