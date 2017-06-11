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

            for (int x1 = -n ; x1 <= n; x1++)          // namiram 1vata to4ka po osta x
            {             
                for (int y1 = n; y1 >= -n; y1--)       // namiram 1vata to4ka po osta y
                {                   
                    for (int x2 = -n ; x2 <= n; x2++)          //namiram 2rata to4ka po x
                    {
                        if (x2 > x1)          // 2rata to4ka trqbva da e vinagi po golqma ot 1vata
                        {                        
                            for (int y2 = n; y2 >= -n; y2--)       // namiram 2rata to4ka po y
                            {
                                if (y2 > y1)      // 2rata to4ka > ot 1vata
                                {                                 
                                    int sideA = Math.Abs(x1 - x2);    // namiram ednata strana po osta x
                                    int sideB = Math.Abs(y1 - y2);    // dr strana razpolojena po y

                                    if (sideA * sideB >= m)     // S na pravougilnika >= m
                                    {
                                        Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",
                                            x1, y1, x2, y2, sideA * sideB);
                                        counter += 1;       // ako ima pone edin pravougulnik promenlivata > 0
                                    }                                    
                                }
                            }
                        }
                       
                    }
                }
            }
            if (counter == 0) // ako ne sme vlezli v gornata proverka, counter trqbva da e = 0
            {                                           // t.e nqma pravougulnik s lice m
                Console.WriteLine("No");
            }
        }
    }
}
