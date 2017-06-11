using System;


namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintWelcomeMsg(name);
        }

        static void PrintWelcomeMsg(string name)
        {
            
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
