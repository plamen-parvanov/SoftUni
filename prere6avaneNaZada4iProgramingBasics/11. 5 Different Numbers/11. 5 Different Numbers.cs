using System;


namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());

            bool haveSuchNumber = false;

            for (int i = firstNum; i <= lastNum; i++)
            {
                for (int j = i + 1; j <= lastNum; j++)
                {
                    for (int k = j + 1; k <= lastNum; k++)
                    {
                        for (int l = k + 1; l <= lastNum; l++)
                        {
                            for (int m = l + 1; m <= lastNum; m++)
                            {
                                
                                Console.WriteLine($"{i} {j} {k} {l} {m}");
                                haveSuchNumber = true;
                            }
                        }
                    }
                }
            }

            if (!haveSuchNumber)
            {
                Console.WriteLine("No");
            }
        }
    }
}
