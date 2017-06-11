using System;


namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSignOfInteger(num);
        }

        static void PrintSignOfInteger(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
        //static void PrintSignOfInteger()
        //{
        //    int num = int.Parse(Console.ReadLine());
        //    if (num > 0 )
        //    {
        //        Console.WriteLine($"The number {num} is positive.");
        //    }
        //    else if (num == 0)
        //    {
        //        Console.WriteLine($"The number {num} is zero.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number {num} is negative.");
        //    }
        //}
    }
}
