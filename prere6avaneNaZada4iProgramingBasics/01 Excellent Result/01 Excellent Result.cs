using System;


namespace _01_Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());
            if (mark >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }

        }
    }
}
