using System;


namespace _02.Excelennt_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = double.Parse(Console.ReadLine());

            if (result >= 5.50)
                Console.WriteLine("Excellent!");
        }
    }
}
