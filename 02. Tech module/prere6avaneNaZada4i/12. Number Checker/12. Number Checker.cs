using System;


namespace _12.Number_Checker
{
    class Program
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!"); ;
            }
        }
    }
}
