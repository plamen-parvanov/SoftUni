using System;


namespace _06.Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int ctrlNum = int.Parse(Console.ReadLine());

            for (int i = M; i >= 1; i--)
            {
                for (int j = N; j >= 1; j--)
                {
                    for (int k = L; k >= 1; k--)
                    {
                        int num = i * 100 + j * 10 + k;
                        if ( num % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (( num + 5) % 10 == 0)
                        {
                            specialNum -= 2;
                        }
                        else if (  num % 2 == 0)
                        {
                            specialNum *= 2;
                        }
                        if (specialNum >= ctrlNum)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNum);
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No! {0} is the last reached special number.", specialNum);
        }
    }
}
