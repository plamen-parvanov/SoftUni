using System;


namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)bricks / (workers * capacity);
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
