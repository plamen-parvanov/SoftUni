namespace _07.Greeting
{

    using System;


    public class Problem07
    {

        public static void Main()
        {
            //Write a program that enters first name, last name and age and 
            //prints "Hello, <first name> <last name>. You are <age> years old."

            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
