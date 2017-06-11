using System;


namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
