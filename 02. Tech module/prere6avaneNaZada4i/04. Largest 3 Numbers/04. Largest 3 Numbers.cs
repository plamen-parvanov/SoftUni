namespace _04.Largest_3_Numbers
{

    using System;
    using System.Linq;

    public class Dictionaries
    {

        public static void Main()
        {
            var numList = Console.ReadLine().Split().Select(double.Parse).ToList();

            var result = numList.OrderByDescending(x => x).Take(3);

            Console.WriteLine(string.Join(" ", result));


        }
    }
}
