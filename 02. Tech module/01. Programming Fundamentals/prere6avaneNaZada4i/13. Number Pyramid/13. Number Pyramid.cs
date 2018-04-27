using System;


namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 0; counter <= n; i++)
            {
                for (int j = 0; j <= i && counter <= n; j++)
                {
                    Console.Write("{0} ", counter);
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
