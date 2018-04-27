using System;


namespace _03.Point_on_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (first > second)
            {
                if (point <= first && point >= second)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
            else
            {
                if (point <= second && point >= first)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
            int dif1 = Math.Abs(first - point);
            int dif2 = Math.Abs(second - point);
            if (dif1 >= dif2)
            {
                Console.WriteLine(dif2);
            }
            else
            {
                Console.WriteLine(dif1);
            }
        }
    }
}
