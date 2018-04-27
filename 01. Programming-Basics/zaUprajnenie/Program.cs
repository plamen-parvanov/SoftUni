using System;


namespace zaUprajnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = 2 - n % 2;
            Console.WriteLine(a);
        }
    }
}
