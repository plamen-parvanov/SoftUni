using System;


namespace _04.Triangle_of_55_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", new string('*', i + 1));
            }
        }
    }
}
