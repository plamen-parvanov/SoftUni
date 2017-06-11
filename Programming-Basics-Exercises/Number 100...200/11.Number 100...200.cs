using System;


namespace Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            var integer = int.Parse(Console.ReadLine());

            if (integer < 100)
                Console.WriteLine("Less than 100");

            else if (integer <= 200)
                Console.WriteLine("Between 100 and 200");

            else
                Console.WriteLine("Greater than 200");
        }
    }
}
