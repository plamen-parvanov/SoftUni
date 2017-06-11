using System;


namespace Problem_01___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double window = 1.5 * 1.5;
            double door = 2 * 1.2;

            double walls = 2 * x * x - door + 2 * (x * y - window);
            double paint4Walls = walls / 3.4;

            double roof = 2 * (x * y + x * h / 2);
            double paint4Roof = roof / 4.3;

            Console.WriteLine("{0:f2}\n{1:f2}", paint4Walls, paint4Roof);
        }
    }
}
