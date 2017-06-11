using System;


namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char l = 'a' ; l <= n + 96; l++)
            {
                Console.WriteLine(l);
            }
        }
    }
}
