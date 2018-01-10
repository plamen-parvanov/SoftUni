namespace _04.Transport
{

    using System;


    public class Problem04
    {

        public static void Main()
        {
            var people = double.Parse(Console.ReadLine());
            var courses = Math.Ceiling(people / (4 + 8 + 12));

            Console.WriteLine(courses);

        }
    }
}
