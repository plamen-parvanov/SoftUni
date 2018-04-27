namespace _01.Hello__Name_
{

    using System;


    public class Arrays
    {

        public static void Main()
        {
            var name = Console.ReadLine();
            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
