using System;


namespace _06_magic_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int forth = i % 10;
                int third = (i / 10) % 10;
                int second = (i / 100) % 10;
                int first = i / 1000;


                if (first != 0 && second != 0 && third != 0 && forth != 0 && n % first == 0 && n % second == 0 && n % third == 0 && n % forth == 0)
                {
                    Console.Write("{0} ", i);
                }


            }
        }
    }
}
