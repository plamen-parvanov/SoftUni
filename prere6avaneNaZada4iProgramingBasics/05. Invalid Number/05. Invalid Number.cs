using System;


namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool invalid = true;

            if (num >= 100 && num <= 200 || num == 0)
            {
                invalid = false;
            }
            if (invalid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
