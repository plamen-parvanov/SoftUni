using System;


namespace _01.Numbers_1._._.N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k < l + 97; k++)
                    {
                        for (char m = 'a'; m < l + 97; m++)
                        {
                            for (int o = 0; o <= n ; o++)
                            {
                                if (o > i && o > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, k, m, o);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
           
               
            
            
            
        }
    }
}
