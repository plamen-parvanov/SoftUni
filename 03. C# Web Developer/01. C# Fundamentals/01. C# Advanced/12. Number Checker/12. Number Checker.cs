namespace _12.Number_Checker
{

    using System;


    public class Problem12
    {

        public static void Main()
        {

            try
            {
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!");
            }

        }
    }
}
