using System;


namespace _10.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = Console.ReadLine();

            if (pass == "s3cr3t!P@ssw0rd")
                Console.WriteLine("Welcome");

            else
                Console.WriteLine("Wrong Password!");
        }
    }
}
