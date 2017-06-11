using System;


namespace _05_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                string left = "//";
                string right = "\\\\"; 
                if (i == 0)
                {
                    left = "__";
                    right = "__";
                }
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', n + 1 - i), left, 
                    new string('_', 2 * n - 3 + 2 * i), right);
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', 2 * n - 3));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', 4 * n - 1 - 2 * i));
            }
        }
    }
}
