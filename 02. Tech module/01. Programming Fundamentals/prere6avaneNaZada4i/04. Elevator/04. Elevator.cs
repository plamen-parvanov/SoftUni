using System;


namespace _04.Elevator
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling(numberOfPeople / capacity);

            Console.WriteLine(courses);
        }
    }
}
