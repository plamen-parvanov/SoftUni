using System;


namespace _06.SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 9999; i++)
            {
               
                int forth = i % 10;
                int third = (i / 10) % 10;
                int second = (i / 100) % 10;
                int first = (i / 1000) % 10;

                if (forth > 0 && third > 0 && second > 0)
                {


                    if (n % forth == 0 && n % third == 0 && n % second == 0 && n % first == 0)
                    {
                        Console.Write("{0}{1}{2}{3} ", first, second, third, forth);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
