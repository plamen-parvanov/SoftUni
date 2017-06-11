using System;


namespace _03.Local_Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidates = int.Parse(Console.ReadLine());
            int voteFor = int.Parse(Console.ReadLine());
            string sing = Console.ReadLine().ToLower();

            for (int i = 0; i < candidates; i++)
            {
                Console.WriteLine(new string('.', 13));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                if (voteFor == i + 1)
                {
                    if (sing == "x")
                    {
                       
                        Console.WriteLine("{0}|.\\./.|{0}", new string('.', 3));
                        Console.WriteLine("{0:d2}.|..X..|{1}", i + 1, new string('.', 3));
                        Console.WriteLine("{0}|./.\\.|{0}", new string('.', 3));
                     

                    }
                    else if (sing == "v")
                    {
                       
                        Console.WriteLine("{0}|\\.../|{0}", new string('.', 3));
                        Console.WriteLine("{0:d2}.|.\\./.|{1}", i + 1, new string('.', 3));
                        Console.WriteLine("{0}|..V..|{0}", new string('.', 3));
                       
                    }
                }

                else
                {
                    
                    Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
                    Console.WriteLine("{0:d2}.|{1}|{2}", i + 1, new string('.', 5), new string('.', 3));
                    Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
                  
                }
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
            }
            Console.WriteLine(new string('.', 13));

        }
    }
}
