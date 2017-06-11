using System;


namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    if (i < j)
                    {
                        int sideA = Math.Abs(j - i);

                        for (int k = -n; k <= n; k++)
                        {
                            for (int l = -n; l <= n; l++)
                            {
                                if (k < l)
                                {
                                     int sideB = Math.Abs(l - k);
                                    int area = sideA * sideB;
                                    if ( area >= m)
                                    {
                                        Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",
                                            i, k, j, l, area);
                                        counter++;
                                    }
                                }
                               
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }


        }
    }
}
