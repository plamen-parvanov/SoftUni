using System;


namespace Problem_03___Fallen_In_Love
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // top
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~',i), 
                    new string('.', 2 * (n - i)), new string('.', 2 * i));
            }

            //middle
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', 1 + 2 * i),
                    new string('~', n - i), new string('.', 2 * (n - i)));
            }

            //bottom
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.', 2 * (n + 1)));
            }

        }
    }
}
