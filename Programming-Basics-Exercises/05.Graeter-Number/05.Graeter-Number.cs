using System;


namespace _05.Graeter_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");

            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
                Console.WriteLine("Graeter number " + firstNumber);

            else
                Console.WriteLine("Greater number " + secondNumber);
        }
    }
}
