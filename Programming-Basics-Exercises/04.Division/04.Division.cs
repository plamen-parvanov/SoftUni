using System;


namespace _04.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var even = 0;
            var three = 0;
            var four = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    even += 1;
                }

                if (num % 3 == 0)
                {
                    three += 1;
                }

                if (num % 4 == 0)
                {
                    four += 1;
                }
            }
            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%",
                even / n * 100, three / n * 100, four / n * 100);
        }
    }
}
