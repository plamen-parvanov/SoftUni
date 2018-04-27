using System;


namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var smallerNumber = int.MaxValue; 

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < smallerNumber)
                {
                    smallerNumber = number;
                }
            }
            Console.WriteLine(smallerNumber);
        }
    }
}
