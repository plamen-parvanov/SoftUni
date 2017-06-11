using System;


namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 800)
                {
                    p5++;
                }
                else if (num >= 600)
                {
                    p4++;
                }
                else if (num >= 400)
                {
                    p3++;
                }
                else if (num >= 200)
                {
                    p2++;
                }
                else
                {
                    p1++;
                }
            }
            double percent = 100d / n;
            Console.WriteLine("{0:p2}\n{1:p2}\n{2:p2}\n{3:f2}\n{4:f2}", 
                p1 / n, p2 / n, p3 / n, p4 * percent, p5 * percent);
        }
    }
}
