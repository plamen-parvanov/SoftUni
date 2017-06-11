using System;


namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main()
        {
            int cntr = 0;

            for (;;)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    cntr++;

                }
                catch (Exception)
                {
                    break;
                }
            }

            Console.WriteLine(cntr);
        }
    }
}
