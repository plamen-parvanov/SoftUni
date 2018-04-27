using System;


namespace _06_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double bonusPoint = 0;
            if (n > 1000)
            {
                bonusPoint = 0.1 * n;
            }
            else if (n > 100)
            {
                bonusPoint = 0.2 * n;
            }
            else
            {
                bonusPoint += 5;
            }
            if (n % 2 == 0)
            {
                bonusPoint += 1;
            }
            if ((n + 5) % 10 == 0)
            {
                bonusPoint += 2;
            }
            Console.WriteLine(bonusPoint);
            Console.WriteLine(bonusPoint + n);
        }
    }
}
