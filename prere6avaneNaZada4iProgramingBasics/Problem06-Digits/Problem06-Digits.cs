using System;


namespace Problem06_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int third = num % 10;
            int second = num / 10 % 10;
            int first = num / 100;

            for (int i = 0; i < first + second; i++)
            {
                for (int j = 0; j < first + third; j++)
                {
                    if (num % 5 == 0)
                    {
                        num -= first;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= second;
                    }
                    else
                    {
                        num += third;
                    }
                    Console.Write(num +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
