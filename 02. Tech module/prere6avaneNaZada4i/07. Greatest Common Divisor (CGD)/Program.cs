using System;


namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            

            while (a % b != 0)
            {
               int newB = a % b;
                a = b;
                b = newB;
            }
            Console.WriteLine(b);
        }
    }
}
