namespace _01.Hello__Name_
{

    using System;

    public class Problem01
    {

        public static void Main()
        {
            var name = Console.ReadLine();

            PrintsHelloName(name);
        }

        public static void PrintsHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
