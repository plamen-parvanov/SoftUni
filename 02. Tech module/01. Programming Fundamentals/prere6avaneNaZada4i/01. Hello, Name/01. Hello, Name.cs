using System;


namespace _01.Hello__Name
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            PrintGreetingByName(name);
        }

        static void PrintGreetingByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
