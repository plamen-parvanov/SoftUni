using System;


namespace _02.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine($"{area:f12}");
        }
    }
}
